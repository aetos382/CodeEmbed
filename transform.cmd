@echo off

set logger=C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll

msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj /p:Transform=CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj.transform /logger:"%logger%"
msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Api\Web.config /p:Transform=CodeEmbed.Web.Api\Web.config.transform /logger:"%logger%"

msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj /p:Transform=CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj.transform /logger:"%logger%"
