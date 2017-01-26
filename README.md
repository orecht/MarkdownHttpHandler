# MarkdownHttpHandler
ISS Http handler to display makrdown .md file

# Installation
Place ORecht.MarkdownHandler.dll in the \bin folder of your ISS site

Edit `web.config` with:
```xml
<configuration>
    <system.webServer>
        <handlers>
            <add name="MarkdownHandler" path="*.md" verb="*" type="System.Web.Handlers.MarkdownHandler" resourceType="Unspecified" requireAccess="Read" preCondition="integratedMode" />
        </handlers>
    </system.webServer>
</configuration>
```

Any .md file is now converted to html and rendered. 

Renmdering is done client side using Strapdown.js

# Credits
http://strapdownjs.com/
