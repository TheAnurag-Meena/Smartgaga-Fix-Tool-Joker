using Joker_Smartgaga_Fix.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Joker_Smartgaga_Fix
{
    public partial class Form1 : Form
    {

       
        private GAME g = new GAME();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start Game
            Console.Beep();
           

            try
            {
                File.WriteAllBytes("C:\\Windows\\System\\adb.exe", Resources.adb);
                File.WriteAllBytes("C:\\Windows\\System\\AdbWinApi.dll", Resources.AdbWinApi);
                
            }
            catch
            {
            }

            if (!this.radioButton1.Checked & !this.radioButton2.Checked & !this.radioButton3.Checked & !this.radioButton4.Checked)
            {
                _ = (int)MessageBox.Show("Select Game Version First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            if (radioButton1.Checked)
            {
                g.GLOBAL();
              

            }
            if (radioButton2.Checked)
            {
                g.TAIWAN();
              

            }
            if (radioButton3.Checked)
            {
                g.KOREA();
                

            }
            if (radioButton4.Checked)
            {
                g.VNG();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open smartgaga
            try
            {
                File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Jockertitan);
                File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Jockertitan);
                File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Jockertitan);
                File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Jockertitan);
            }
            catch
            { 
            }

            try
            {
                string exepathc = "C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }

            try
            {
                string exepathc = "G:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\Launcher.exe";

                if ((File.Exists(exepathc)))
                {
                    Process.Start(exepathc);

                }
            }
            catch
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close Emulator

            button3.Enabled = false;
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
                standardInput.WriteLine("taskkill /f /im adb.exe");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am kill com.tencent.ig");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am force-stop com.tencent.ig");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am kill com.rekoo.pubgm");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am force-stop com.rekoo.pubgm");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am kill com.pubg.krmobile");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am force-stop com.pubg.krmobile");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am kill com.vng.pubgmobile");
                standardInput.WriteLine("C:\\Windows\\System\\adb.exe -s emulator-5554 shell am force-stop com.vng.pubgmobile");
                standardInput.WriteLine("taskkill /f /im ProjectTitan.exe & taskkill /f /im AndroidProcess.exe & taskkill /f /im adb.exe & taskkill /f /im TitanService.exe");
            }
            process.WaitForExit();
            {
                try
                {
                    File.WriteAllBytes("C:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Otitan);
                    File.WriteAllBytes("D:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Otitan);
                    File.WriteAllBytes("E:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Otitan);
                    File.WriteAllBytes("F:\\Program Files (x86)\\SmartGaGa\\ProjectTitan\\Engine\\titan.pak", Resources.Otitan);
                }
                catch
                {
                }
                button3.Enabled = true;
            }
        }
    }
}
