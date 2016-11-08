msbuild.exe ..\LiteolikaMediaplayer.sln /p:outdir="..\build\app",configuration=RELEASE /t:Clean;Build

"c:\Program Files (x86)\NSIS\makensis.exe" installer.nsi 
