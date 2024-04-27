using System;
using System.Diagnostics;

namespace Window
{
    class Window_GUI
    {
        public static void Load()
        {
            Console.Title = "Grade Evaluator In C#";
            Refresh();
        }

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
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();
                Console.WriteLine("Output: " + output);
                Console.WriteLine("Error: " + error);
                process.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}