@echo off

del .\CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj.user
del .\CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj.user

attrib -h .\CodeEmbed.v12.suo
del .\CodeEmbed.v12.suo
