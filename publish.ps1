$version = (Select-Xml -Path Directory.Build.props -XPath '/Project/PropertyGroup/Version').Node.'#text'
$version
dotnet build --configuration Release
dotnet test --configuration Release
dotnet pack --configuration Release
$confirmation = Read-Host "Are you sure you want to push nuget packages (y - yes, n - no):"
if ($confirmation -eq 'y') {
	$source = https://api.nuget.org/v3/index.json
	$apiKey = $Env:NUGET_API_KEY
	dotnet nuget push ".\FFmpeg.AutoGen\bin\Release\FFmpeg.AutoGen.$version.nupkg" --source $source --api-key $apiKey
	dotnet nuget push .\FFmpeg.AutoGen.Abstractions\bin\Release\FFmpeg.AutoGen.Abstractions.$version.nupkg --source $source --api-key $apiKey
	dotnet nuget push .\FFmpeg.AutoGen.Bindings.DynamicallyLinked\bin\Release\FFmpeg.AutoGen.Bindings.DynamicallyLinked.$version.nupkg --source $source --api-key $apiKey
	dotnet nuget push .\FFmpeg.AutoGen.Bindings.DynamicallyLoaded\bin\Release\FFmpeg.AutoGen.Bindings.DynamicallyLoaded.$version.nupkg --source $source --api-key $apiKey
	dotnet nuget push .\FFmpeg.AutoGen.Bindings.StaticallyLinked\bin\Release\FFmpeg.AutoGen.Bindings.StaticallyLinked.$version.nupkg --source $source --api-key $apiKey
	git tag v$version
	git push origin v$version
}