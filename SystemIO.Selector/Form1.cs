using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SystemIO.Selector
{
    public partial class Form1 : Form
    {
        public string strExecutingFrom = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public string strConsoleApp = @"E:\OneDrive\Documents\Visual Studio 2017\Projects\SystemIO\SystemIO.Cmd\bin\Debug\SystemIO.Cmd.exe";
        public string strWindowsApp = @"E:\OneDrive\Documents\Visual Studio 2017\Projects\SystemIO\SystemIO.Windows\bin\Debug\SystemIO.Windows.exe";
        public string strWPFApp = @"E:\OneDrive\Documents\Visual Studio 2017\Projects\SystemIO\SystemIO.WPF\bin\Debug\SystemIO.WPF.exe";


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsole_Click(object sender, EventArgs e)
        {

            StartProcess(strConsoleApp);
            
        }

        private void StartProcess(string ProgramToExecute)
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = ProgramToExecute,
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = true
            };
            int exitCode;
          

            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
        }

        private void BtnWindows_Click(object sender, EventArgs e)
        {
            StartProcess(strWindowsApp);
        }

        private void BtnWPF_Click(object sender, EventArgs e)
        {
            StartProcess(strWPFApp);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
