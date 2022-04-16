using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCSharpToPython
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cmdToBeExecute = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\myScript.py";
            //var start = new ProcessStartInfo
            //{
            //    FileName = "C:\\Python27\\python.exe",
            //    Arguments = string.Format("{0} {1}", cmdToBeExecute, "\"Rahul done good\""),
            //    UseShellExecute = false,
            //    RedirectStandardOutput = true,
            //    CreateNoWindow = true
            //};
            run_cmd(@"C:\\Users\Home\Desktop\Bot_Vk\Bot_Vk_N1.py", "");
            Console.ReadLine();
        }



       static private void run_cmd(string cmd, string args)
        {
           
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\\Users\Home\AppData\Local\Programs\Python\Python38\python.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = true;
            //start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            Process.Start(start);
            //using (Process process = Process.Start(start))
            //{
            //    //using (StreamReader reader = process.StandardOutput)
            //    //{
            //    //    string result = reader.ReadToEnd();
            //    //    Console.Write(result);
            //    //}
            //}


        }



    }
}
