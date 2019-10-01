$outputDir = ".\package\"
$build = "Release"
$version = "11.1.0"

nuget.exe pack ".\src\AceEditor\AceEditor.v11.csproj" -IncludeReferencedProjects -properties Configuration=$build -Version $version -OutputDirectory $outputDir
