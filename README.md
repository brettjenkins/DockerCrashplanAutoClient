# DockerCrashplanAutoClient
Simple script that allows you to have a one click shortcut that will always connect to a Docker Crashplan Client

I built this as a I use crashplan on docker on Synology and everytime the docker instance starts up it seems to pick another hash that I have to copy and paste into .ui_info on my client machine, and it's very annoying. This script (and very very simple and quick and dirty .NET application) just SSH's in to the docker instance, gets the .ui_info key, put's it in your .ui_info on your machine and then runs crashplan. Much easier!

Prerequisites

You'll need Visual Studio - you can get the community version for free.
You'll need to download the plink.exe from putty.


To Use

1) You'll need to compile CrashplanRenamer/CrashplanRenamer.sln. Because this is quick and dirty which I wrote for my own use and I just wanted to share it, the path to the crashplanOutput.txt that the batch file generates is hardcoded to C:\Scripts\crashplanOutput.txt you can change this to whereever you want in Visual Studio.

2) You'll need to then go through the batch files and change the IP and Password.

3) You'll need to download plink.exe from putty (http://www.chiark.greenend.org.uk/~sgtatham/putty/download.html) and put in same directory as batch file.

Job done!