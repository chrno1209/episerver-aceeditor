@Echo Removing old files
del Package\lib /s /q
del Package\content /s /q

@Echo Setting up folder structure
md Package\lib\net45\
md Package\content\modules\_protected\AceEditor\ClientResources\Scripts\AceEditor\

@Echo Copying new files
copy ..\src\AceEditor\bin\Debug\AceEditor.dll Package\lib\net45\
copy ..\src\AceEditor\module.config Package\content\modules\_protected\AceEditor\

xcopy /s ..\src\AceEditor\ClientResources\Scripts\AceEditor Package\content\modules\_protected\AceEditor\ClientResources\Scripts\AceEditor


@Echo Packing files
"nuget.exe" pack Package\AceEditor.nuspec
