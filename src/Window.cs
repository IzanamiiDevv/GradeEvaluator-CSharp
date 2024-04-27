using System;
using System.Diagnostics;

namespace Window
{
    class Window_GUI
    {
        public static void Load()
        {
            Console.Title = "Grade Evaluator In C#";
        }

        //Script not Running.
        public static void Refresh()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process.StartInfo = startInfo;
                process.Start();
                process.StandardInput.WriteLine("cls");
                process.StandardInput.Flush();
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}