﻿using System.Diagnostics;
using System.IO;

namespace Joker_Smartgaga_Fix
{
    internal class GAME
    {

        public void GLOBAL()
        {

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput/cache");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am start -n com.tencent.ig/com.epicgames.ue4.SplashActivity filter");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");

            }


        }

        public void TAIWAN()
        {

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput/cache");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am start -n com.rekoo.pubgm/com.epicgames.ue4.SplashActivity filter");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");

            }
        }




        public void KOREA()
        {


            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput/cache");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity filter");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");


            }


        }



        public void VNG()
        {

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                if (!standardInput.BaseStream.CanWrite)
                    return;
                standardInput.WriteLine("taskkill /f /im adb.exe & taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s connect emulator-5554");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell mkdir /data/data/com.tencent.tinput/cache");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am start -n com.vng.pubgmobile/com.epicgames.ue4.SplashActivity filter");
                standardInput.WriteLine("taskkill /f /im processhacker.exe & taskkill /f /im Procmon64.exe & taskkill /f /im apimonitor-x64 & taskkill /f /im apimonitor-x64");


            }

        }

    }
}
