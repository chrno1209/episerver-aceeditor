$outputDir = "..\..\package\"
$build = "Release"
$version = "12.1.1"

msbuild -t:pack ".\src\AceEditor\AceEditor.v12.csproj" -p:Configuration=$build -p:PackageVersion=$version -p:PackageOutputPath=$outputDir
