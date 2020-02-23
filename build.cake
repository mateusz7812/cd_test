#tool "nuget:?package=xunit.runner.console"

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

Task("dotnet-restore")
	.Does(() => 
	{
		DotNetCoreRestore("./WebApplication3.sln");
	});


Task("dotnet-build")
	.IsDependentOn("dotnet-restore")	
	.Does(() => 
	{
		DotNetCoreBuild("./WebApplication3.sln", new DotNetCoreBuildSettings 
		{
			Configuration = configuration
		});
	});

Task("run-xunit-tests")	
	.IsDependentOn("dotnet-build")
	.Does(() => 
	{
		DotNetCoreTest("./UnitTestProject1/UnitTestProject1.csproj", new DotNetCoreTestSettings
		{
			Configuration = configuration
		});
	});	

Task("Default")
	.IsDependentOn("run-xunit-tests");

RunTarget(target);