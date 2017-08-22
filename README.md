# Battle-Net-Launcher-Lite
A very lightweight custom Bnet launcher that doesn't rely on the official Battle.Net launcher

# Usage instructions
Modify "Form1.vb" line 23, replacing "System.Diagnostics.Process.Start("C:\Program Files (x86)\StarCraft II\Support64\SC2Switcher_x64.exe")" with "System.Diagnostics.Process.Start("[Your Starcraft Directory]\StarCraft II\Support64\SC2Switcher_x64.exe")"
Compile via Visual Studio

# Optional
If your path is already C:\Program Files (x86)\StarCraft II, simply download the entire branch, open "Battle.Net Launcher.sln" in Visual Studio, and hit "Build" in the top bar. It will be compiled and ready to run via the executable located in ../Bin/Debug

# Explanation 
I chose to manually insert your directory instead of finding it via code due to system resources. The application is meant to run with the absolute minimum of system resources, including disk time. 
