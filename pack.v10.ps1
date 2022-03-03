$outputDir = "..\..\package\"
$build = "Release"
$version = "10.1.1"

msbuild -t:pack ".\src\AceEditor\AceEditor.v10.csproj" -p:Configuration=$build -p:PackageVersion=$version -p:PackageOutputPath=$outputDir
