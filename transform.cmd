@echo off

setlocal

set EXIT_CODE=0
set logger=C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll

msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj /p:Transform=CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj.transform /logger:"%logger%"
if errorlevel 1 set EXIT_CODE=%ERRORLEVEL% && goto END_TRANSFORM

msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Api\Web.config /p:Transform=CodeEmbed.Web.Api\Web.config.transform /logger:"%logger%"
if errorlevel 1 set EXIT_CODE=%ERRORLEVEL% && goto END_TRANSFORM

msbuild.exe transform.proj /p:Source=CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj /p:Transform=CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj.transform /logger:"%logger%"
if errorlevel 1 set EXIT_CODE=%ERRORLEVEL% && goto END_TRANSFORM

:END_TRANSFORM

endlocal && exit /b %EXIT_CODE%
