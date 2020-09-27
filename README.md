# GMLauncher

![Image preview of GMLauncher](launcher.png)

GMLauncher is a custom launcher for use with HITMAN 2 and LocalGhost.

It is NOT affiliated with LocalGhost.

<br>


## Launcher Instructions

1. Download the latest version of "GMLauncher" from:<br>
https://github.com/tuglaw/GMLauncher/releases/latest

2. Download LocalGhost’s "Hitman2Patcher" from:<br>
https://gitlab.com/grappigegovert/localghost/-/jobs/artifacts/master/download?job=build_patcher

3. Place both “GMLauncher.exe” and "Hitman2Patcher.exe" in the "HITMAN2" folder

4. (Optional) Skip the original HITMAN 2 launcher:

    4.1. Right-click HITMAN 2 on Steam and choose "Properties"
    
    4.2. Press the "Set Launch Options" button
    
    4.3. Type in "-SKIP_LAUNCHER" without the quotation marks and press OK. If you want to use DirectX 12, type in "-SKIP_LAUNCHER -d3d12".

**Note:** GMLauncher requires the Microsoft .NET Framework 4.x redistributable package.

<br>

## Server Instructions

1. Extract the "Server" folder from GMLauncher’s “extras” into the “HITMAN2” folder

2. Install NodeJS (LTS version is recommended): https://nodejs.org/en/download/

3. Download the "LocalGhost" GitLab project from:<br>
https://gitlab.com/grappigegovert/localghost/-/archive/master/localghost-master.zip

4. Extract the "Server" folder from "localghost-master.zip" into the “HITMAN2” folder<br>
(example: <Steam folder>\steamapps\common\HITMAN2\Server)

5. Run the "npm install.bat" in the “Server” folder to install all NodeJS dependencies (you can delete the file after)
