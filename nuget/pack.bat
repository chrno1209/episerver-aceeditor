@Echo Removing old files
del Package\lib /s /q
del Package\content /s /q

@Echo Setting up folder structure
md Package\lib\net45\
md Package\tools\
md Package\content\modules\_protected\AceEditor\ClientResources\Scripts\AceEditor\

@Echo Copying new files
copy ..\src\EPiServer.Plugins.Editors.AceEditor\bin\Debug\EPiServer.Plugins.Editors.AceEditor.dll Package\lib\net45\
copy ..\src\EPiServer.Plugins.Editors.AceEditor\module.config Package\content\modules\_protected\AceEditor\

xcopy /s ..\src\EPiServer.Plugins.Editors.AceEditor\ClientResources\Scripts\AceEditor Package\content\modules\_protected\AceEditor\ClientResources\Scripts\AceEditor


@Echo Packing files
"nuget.exe" pack AceEditor.nuspec
