using System;
using System.Security.Principal;
using Microsoft.Win32;

namespace SidGuidChange.Methods
{
    public class Functions
    {

        public static void InvalidRequest()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("|-------------------------------------------------|");
            Console.WriteLine("|- INVALID Request! Only Selections are accepted -|");
            Console.WriteLine("|----------- Press ENTER to continue -------------|");
            Console.WriteLine("|-------------------------------------------------|");
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static void SidGuidRead()
        {
            string getSid;
            using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent())
            {
                getSid = windowsIdentity.User.AccountDomainSid.Value.ToString();
                // (0, windowsIdentity.User.AccountDomainSid.Value.LastIndexOf('-'))
            }

            object value = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", @"MachineGuid", (object)"defaultValue");
            RegistryKey keyBase = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = keyBase.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", RegistryKeyPermissionCheck.ReadSubTree);
            value = key.GetValue("MachineGuid");
            if (value != null && value.ToString() != "defaultValue")
            { 
                key.Close();
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------------------|");
            Console.WriteLine($"|Your SiD is :\t" + getSid+"|");
            Console.WriteLine($"|Your GuiD is :\t" + value+"     |");
            Console.WriteLine("|-------------------------------------------------------|");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Return ...");
            Console.ReadLine();


        }

        public static void SidChanger()
        {
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                pProcess.StartInfo.FileName = "notepad.exe";
                pProcess.StartInfo.Arguments = "olaa"; //argument
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                pProcess.Start();
                string output = pProcess.StandardOutput.ReadToEnd(); //The output result
                pProcess.WaitForExit();
            }
        }

    }
}
