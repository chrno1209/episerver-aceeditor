$outputDir = "..\..\package\"
$build = "Release"
$version = "11.1.1"

msbuild -t:pack ".\src\AceEditor\AceEditor.v11.csproj" -p:Configuration=$build -p:PackageVersion=$version -p:PackageOutputPath=$outputDir
