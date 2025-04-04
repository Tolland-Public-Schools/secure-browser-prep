# secure-browser-prep
App to close prohibited apps before using secure testing browsers.

To create a .exe file, run: dotnet publish -c Release -r win10-x64
Open included .aip file in Advanced Installer
Click Build to create .msi file in SecureBrowserPrepInstaller folder
Run .\IntuneWinAppUtil.exe -c .\SecureBrowserPrepInstaller\ -s SecureBrowserPrep.msi -o .
That will create the intunewin file you can upload to Intune

If you have errors that System.Object is not imported, set VS Code mono option to auto in VS Code settings