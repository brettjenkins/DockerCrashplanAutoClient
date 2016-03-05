plink.exe -ssh root@IP -pw PASSWORD -m dockerCrashplan.txt > crashplanOutput.txt

call runCrashplanRenamer.cmd

start "" "C:\Program Files\CrashPlan\CrashPlanDesktop.exe"