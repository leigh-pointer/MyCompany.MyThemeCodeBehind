"..\..\oqtane.framework\oqtane.package\nuget.exe" pack MyCompany.MyThemeCodeBehind.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Themes\" /Y
