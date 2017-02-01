# Packaging MarkdownHttpHandler as a Nuget

## Process 

```
 nuget pack MarkdownHttpHandler.nuspec
 nuget push MarkdownHttpHandler.0.8.10.nupkg -Source e:\LocalNugets
```

## Problem
MarkdownHttpHandler installation needs to
* unpack dll
* add lines to web.config

### Problem 1: bin or lib directory?
IIS requires the dll to be in \bin directory of the website (or at web server level)
Nuget by default wants dlls in \lib directory. This behaviour can be overriden. But when overriden it does not work in Visual Studio.

### Problem 2: inserting lines in web.config does not always work 
NuGet can run XDT transform on `web.cong` or `app.config` when installing or uninstalling the package.
But there are differences in the implementation when installation is called with `nuget install` (standalone) or within VS `install-package`. 
**XDT transform only happen when installation is done in Visual Studio**. `nuget install` installs the NuGet but does not run the transform!

Workaround would be to use config.ps1 script.

### Conclusion: 
We have to decide if we what to make a NuGet for inclusion in VS or a package to deploy to a website. 

At the moment we have 2 NuGets: 
* MarkdownHttpHandler: `\bin` directory. transform does not work
* MarkdownHttpHandler_lib: `\lib` directory. transform works if installed from Visual Studio.



