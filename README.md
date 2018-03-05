[![Platform](https://img.shields.io/badge/Episerver-%2010.0.+-orange.svg?style=flat)](http://world.episerver.com/cms/)

# EPiServer AceEditor
This is an integration for EPiServer to use [Ace](https://github.com/ajaxorg/ace) editor, a well-known code editor for the web.

> Please note that the original code is for EPiServer v10, for v11 you can find the code in **[Episerver v11 compatibility](https://github.com/chrno1209/episerver-aceeditor/tree/Episerver_v11_compatibility)** branch

---------------------------------------------------------
To use AceEditor in your project, first try to install it via EPiServer Nuget
```
PM> Install-Package AceEditor
```

In your project, decorate your **string** property with UIHint attribute
```
[UIHint(AceEditor.UIHints.Javascript)]
```

AceEditor can support many languages, but as some of them is not quite popular, so I just pick the one which are suitable to use.
The list of supported languages are:
- C_Cpp
- Coffee
- Csharp
- Css
- Django
- Handlebars
- Html
- HtmlElixir
- HtmlRuby
- Java
- Javascript
- Json
- Jsp
- Less
- Lua
- Lucene
- Markdown
- Mysql
- ObjectiveC
- Pascal
- Perl
- Pgsql
- Php
- Powershell
- Python
- Razor
- Rhtml
- Ruby
- Sass
- Scheme
- Scss
- Sql
- Sqlserver
- Svg
- Swift
- Text
- Typescript
- Vbscript
- Xml
- Xquery
- Yaml
