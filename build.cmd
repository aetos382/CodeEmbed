@echo off

set logger=C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll
set outputPath=bin\%Platform%\%Configuration%\
set publishParams=/p:WebPublishMethod=FileSystem /p:DeleteExistingFiles=True /p:PrecompileBeforePublish=True

msbuild.exe CodeEmbed.GitHubClient\CodeEmbed.GitHubClient.csproj /t:Build /l:"%logger%" /m /p:OutputPath="%outputPath%"
if errorlevel 1 exit /b %ERRORLEVEL%

msbuild.exe CodeEmbed.GitHubClient.Tests\CodeEmbed.GitHubClient.Tests.csproj /t:Build /l:"%logger%" /m /p:OutputPath="%outputPath%"
if errorlevel 1 exit /b %ERRORLEVEL%

msbuild.exe CodeEmbed.Web.Http\CodeEmbed.Web.Http.csproj /t:Build /l:"%logger%" /m /p:OutputPath="%outputPath%"
if errorlevel 1 exit /b %ERRORLEVEL%

msbuild.exe CodeEmbed.Web.Api\CodeEmbed.Web.Api.csproj /t:Build;WebPublish /l:"%logger%" /m /p:OutputPath="%outputPath%" %publishParams% /p:PublishUrl="..\Publish\CodeEmbed.Web.Api"
if errorlevel 1 exit /b %ERRORLEVEL%

msbuild.exe CodeEmbed.Web.Api.Tests\CodeEmbed.Web.Api.Tests.csproj /t:Build /l:"%logger%" /m /p:OutputPath="%outputPath%"
if errorlevel 1 exit /b %ERRORLEVEL%

msbuild.exe CodeEmbed.Web.Site\CodeEmbed.Web.Site.csproj /t:Build;WebPublish /l:"%logger%" /m /p:OutputPath="%outputPath%" %publishParams% /p:AspNetBuildViews=True /p:PublishUrl="..\Publish\CodeEmbed.Web.Site"
if errorlevel 1 exit /b %ERRORLEVEL%

exit /b 0
