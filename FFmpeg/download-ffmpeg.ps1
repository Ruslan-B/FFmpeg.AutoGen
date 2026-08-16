<#
.SYNOPSIS
    Downloads FFmpeg headers and shared libraries for development and code generation.

.DESCRIPTION
    Downloads a pinned FFmpeg full-build-shared release from GyanD/codexffmpeg
    and extracts headers to FFmpeg/include/ and DLLs to FFmpeg/bin/x64/.

.PARAMETER Version
    FFmpeg release tag on GyanD/codexffmpeg (default: 9.0.1).

.PARAMETER Force
    Overwrite existing headers and DLLs.

.EXAMPLE
    .\download-ffmpeg.ps1
    .\download-ffmpeg.ps1 -Version 9.0.1 -Force
#>

param(
    [string]$Version = "9.0.1",
    [switch]$Force
)

$ErrorActionPreference = "Stop"

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$BinDir = Join-Path $ScriptDir "bin\x64"
$IncludeDir = Join-Path $ScriptDir "include"
$TempDir = Join-Path $ScriptDir "temp"

$ArchiveName = "ffmpeg-$Version-full_build-shared.zip"
$Url = "https://github.com/GyanD/codexffmpeg/releases/download/$Version/$ArchiveName"

if ((Test-Path (Join-Path $BinDir "avcodec-*.dll")) -and -not $Force) {
    Write-Host "FFmpeg DLLs already exist in $BinDir"
    Write-Host "Re-run with -Force to overwrite, or delete bin/ and include/ manually."
    exit 0
}

Write-Host "Downloading FFmpeg $Version from $Url"

New-Item -ItemType Directory -Force -Path $TempDir | Out-Null
$ArchivePath = Join-Path $TempDir $ArchiveName

try {
    Invoke-WebRequest -Uri $Url -OutFile $ArchivePath -UseBasicParsing
} catch {
    Write-Error "Failed to download FFmpeg $Version. URL: $Url`n$_"
    Remove-Item -Recurse -Force $TempDir -ErrorAction SilentlyContinue
    exit 1
}

Write-Host "Extracting..."
Expand-Archive -Path $ArchivePath -DestinationPath $TempDir -Force

$ExtractedDir = Get-ChildItem -Path $TempDir -Directory | Where-Object { $_.Name -like "ffmpeg-*" } | Select-Object -First 1
if (-not $ExtractedDir) {
    Write-Error "Could not find extracted FFmpeg directory in $TempDir"
    Remove-Item -Recurse -Force $TempDir
    exit 1
}

$DllSource = Join-Path $ExtractedDir.FullName "bin"
$IncludeSource = Join-Path $ExtractedDir.FullName "include"

if (-not (Test-Path $DllSource)) {
    Write-Error "Expected bin directory not found: $DllSource"
    Remove-Item -Recurse -Force $TempDir
    exit 1
}
if (-not (Test-Path $IncludeSource)) {
    Write-Error "Expected include directory not found: $IncludeSource"
    Remove-Item -Recurse -Force $TempDir
    exit 1
}

Write-Host "Replacing $BinDir"
if (Test-Path $BinDir) { Remove-Item -Recurse -Force $BinDir }
New-Item -ItemType Directory -Force -Path $BinDir | Out-Null
Copy-Item "$DllSource\*.dll" -Destination $BinDir -Force

Write-Host "Replacing $IncludeDir"
if (Test-Path $IncludeDir) { Remove-Item -Recurse -Force $IncludeDir }
New-Item -ItemType Directory -Force -Path $IncludeDir | Out-Null
Copy-Item "$IncludeSource\*" -Destination $IncludeDir -Recurse -Force

Remove-Item -Recurse -Force $TempDir

$DllCount = (Get-ChildItem "$BinDir\*.dll").Count
$HeaderCount = (Get-ChildItem $IncludeDir -Recurse -Filter "*.h").Count
Write-Host "Done! FFmpeg ${Version}: $DllCount DLLs, $HeaderCount headers."
