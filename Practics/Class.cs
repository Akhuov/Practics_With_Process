using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    public class Class
    {
        public static void CopyFolder()
        {
            string sourceFolder = "C:\\Program Files (x86)";
            string destinationFolder = "D:\\Folder";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();


            startInfo.FileName = "robocopy.exe";
            startInfo.Arguments = $"\"{sourceFolder}\" \"{destinationFolder}\" /E";


            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            process.StartInfo = startInfo;
            process.Start();


            string output = process.StandardOutput.ReadToEnd();


            process.WaitForExit();


            int exitCode = process.ExitCode;


            if (exitCode != 0)
            {
                Console.WriteLine($"An error occurred while copying the folder: {output}");
            }
            else
            {
                Console.WriteLine("Folder copied successfully!");
            }
        }
    }
}
