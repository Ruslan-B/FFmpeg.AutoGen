<#
.SYNOPSIS
    Downloads FFmpeg shared libraries for application run-time use.

.DESCRIPTION
    Downloads a pinned FFmpeg full-build-shared release from GyanD/codexffmpeg
    and copies DLLs from the archive's bin directory to DestinationFolder.
    Use IncludeExes to also copy FFmpeg command-line tools from the same bin directory.

.PARAMETER Version
    FFmpeg release tag on GyanD/codexffmpeg (default: 8.1).

.PARAMETER DestinationFolder
    Destination folder for the FFmpeg binaries.

.PARAMETER IncludeExes
    Also copy .exe files from the FFmpeg bin directory.

.PARAMETER Force
    Overwrite existing FFmpeg binaries.

.EXAMPLE
    .\download-ffmpeg-runtime.ps1 -DestinationFolder .\bin\x64

.EXAMPLE
    .\download-ffmpeg-runtime.ps1 -Version 8.1 -DestinationFolder .\publish -IncludeExes -Force
#>

[CmdletBinding()]
param(
    [string]$Version = "8.1",

    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string]$DestinationFolder,

    [switch]$IncludeExes,

    [switch]$Force
)

$ErrorActionPreference = "Stop"

$DestinationFolderPath = $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath($DestinationFolder)
$TempRoot = Join-Path ([System.IO.Path]::GetTempPath()) "FFmpeg.AutoGen"
$TempDir = Join-Path $TempRoot ([System.Guid]::NewGuid().ToString("N"))

$ArchiveName = "ffmpeg-$Version-full_build-shared.zip"
$Url = "https://github.com/GyanD/codexffmpeg/releases/download/$Version/$ArchiveName"

try {
    if ((Test-Path (Join-Path $DestinationFolderPath "avcodec-*.dll")) -and -not $Force) {
        Write-Host "FFmpeg DLLs already exist in $DestinationFolderPath"
        Write-Host "Re-run with -Force to overwrite, or delete the existing FFmpeg DLLs manually."
        exit 0
    }

    Write-Host "Downloading FFmpeg $Version from $Url"

    New-Item -ItemType Directory -Force -Path $TempDir | Out-Null
    $ArchivePath = Join-Path $TempDir $ArchiveName

    try {
        Invoke-WebRequest -Uri $Url -OutFile $ArchivePath -UseBasicParsing
    } catch {
        Write-Error "Failed to download FFmpeg $Version. URL: $Url`n$_"
        exit 1
    }

    Write-Host "Extracting..."
    Expand-Archive -Path $ArchivePath -DestinationPath $TempDir -Force

    $ExtractedDir = Get-ChildItem -Path $TempDir -Directory | Where-Object { $_.Name -like "ffmpeg-*" } | Select-Object -First 1
    if (-not $ExtractedDir) {
        Write-Error "Could not find extracted FFmpeg directory in $TempDir"
        exit 1
    }

    $BinarySource = Join-Path $ExtractedDir.FullName "bin"

    if (-not (Test-Path -Path $BinarySource -PathType Container)) {
        Write-Error "Expected bin directory not found: $BinarySource"
        exit 1
    }

    $DllFiles = @(Get-ChildItem -Path $BinarySource -Filter "*.dll" -File)
    if ($DllFiles.Count -eq 0) {
        Write-Error "No DLL files found in $BinarySource"
        exit 1
    }

    New-Item -ItemType Directory -Force -Path $DestinationFolderPath | Out-Null

    Write-Host "Copying DLLs to $DestinationFolderPath"
    foreach ($DllFile in $DllFiles) {
        Copy-Item -LiteralPath $DllFile.FullName -Destination $DestinationFolderPath -Force
    }

    $ExeFiles = @()
    if ($IncludeExes) {
        $ExeFiles = @(Get-ChildItem -Path $BinarySource -Filter "*.exe" -File)

        Write-Host "Copying EXEs to $DestinationFolderPath"
        foreach ($ExeFile in $ExeFiles) {
            Copy-Item -LiteralPath $ExeFile.FullName -Destination $DestinationFolderPath -Force
        }
    }

    $Summary = "Done! FFmpeg ${Version}: $($DllFiles.Count) DLLs"
    if ($IncludeExes) {
        $Summary += ", $($ExeFiles.Count) EXEs"
    }

    Write-Host "$Summary copied to $DestinationFolderPath."
} finally {
    if (Test-Path -Path $TempDir) {
        Remove-Item -Recurse -Force $TempDir
    }
}
