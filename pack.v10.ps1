$outputDir = ".\package\"
$build = "Release"
$version = "10.1.0"

nuget.exe pack ".\src\AceEditor\AceEditor.v10.csproj" -IncludeReferencedProjects -properties Configuration=$build -Version $version -OutputDirectory $outputDir
