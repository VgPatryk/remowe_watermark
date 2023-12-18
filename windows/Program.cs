using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\svsvc", true);
            if (myKey != null)
            {
                myKey.SetValue("Start",0x04);
                Console.WriteLine(myKey.GetValue("Start").ToString());
                myKey.Close();
            }
            Console.ReadLine();
        }
    }
}
