# Calc
This is my own modified sample for UI test automation of the Windows calculator using SpecFlow + Appium + WinAppDriver + xUnit

Built using VS2019 + .NET 5 + xUnit test runner

I made my own using a lot of copy/paste and documented it along the way, as I couldn't get the OOB samples to work.
For instance the Navigate to Standard buttons were causing an exception, so I used Accessibility insights to get the name of the button and replaced it with:
  _driver.Current.FindElementByName("Open Navigation").Click();
  _driver.Current.FindElementByName("Scientific Calculator").Click();

Steps:
1. Download Accessibility Insights for Windows · https://accessibilityinsights.io/docs/en/windows/overview/

2. Install latest version of WinAppDriver - https://github.com/Microsoft/WinAppDriver/releases

3. Create appsettings.json or app.settings file specifying the location of the WinAppDriver.exe:
	{
	  "winAppUri": "http://127.0.0.1:4723",
	  "winAppPath": "C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe"
	}
	
4. Add/Create a SpecFlow test project

5. Install the following Nuget packages into the SpecFlow test project (substitute testing framework as applicable such as xunit/nunit/mstest):
	Appium.webdriver
	Fluentassertions
	Microsoft.extensions.configuration
	Microsoft.extensions.configuration.json
	Specflow.plus.livingdocplugin
	Specflow.xunit
  xunit
