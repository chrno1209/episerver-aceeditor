[![Platform](https://img.shields.io/badge/Episerver-%2010.0.+-orange.svg?style=flat)](http://world.episerver.com/cms/)
[![Platform](https://img.shields.io/badge/Episerver-%2011.0.+-orange.svg?style=flat)](http://world.episerver.com/cms/)
[![Platform](https://img.shields.io/badge/Episerver-%2012.0.+-orange.svg?style=flat)](http://world.episerver.com/cms/)

# EPiServer AceEditor
This is an integration for EPiServer to use [Ace](https://github.com/ajaxorg/ace) editor, a well-known code editor for the web.

---------------------------------------------------------
To use AceEditor in your project, first try to install it via EPiServer Nuget
```
PM> Install-Package AceEditor
```

Before CMS 12, the module is loaded in web.config and should be automatically added when the package is installed.
After CMS 12, the module is loaded explicitly during startup with the following example: 

```
public class Startup
{
    ...
    public void ConfigureServices(IServiceCollection services)
    {
        ...
        services.AddAceEditor();
        ...
    }
    ...
}
```

In your project, decorate your **string** property with UIHint attribute
```
[UIHint(AceEditor.UIHints.Javascript)]
```
Also supports **XhtmlString** property type for Html language.

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
