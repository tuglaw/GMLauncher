using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;

namespace GMLauncher
{
    class Launcher
    {
        public static void RunWarning()
        {
            Application.Current.MainWindow.Activate();
            Application.Current.MainWindow.Topmost = true;
            Application.Current.MainWindow.Focus();
            MessageBoxResult result =
                MessageBox.Show("Both GMLauncher.exe and Hitman2Patcher.exe must be inside the HITMAN2 folder.", "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            switch (result)
            {
                case MessageBoxResult.OK:
                    Application.Current.MainWindow.Topmost = false;
                    break;
            }
        }

        public static void RunGame()
        {
            if (!File.Exists("Hitman2Patcher.exe"))
            {
                RunWarning();
            }
            else
            {
                Process.Start("steam://rungameid/863550");
                Thread.Sleep(1000);
                Process.Start("Hitman2Patcher.exe");
                Application.Current.Shutdown();
            }
        }

        public static void PlayButton()
        {
            //Process.Start(@"<steamapps>\common\HITMAN2\Launcher.exe", "-SKIP_LAUNCHER");

            RunGame();
        }

        public static void ServerButton()
        {
            //const string strCmdText = "/K cd Server&set path=%ProgramFiles%/Nodejs&node serb.js";
            
            /* Launcher must be inside Server folder */
            //const string strCmdText = "/K node serb.js";

            /* Launcher must be inside HITMAN2 folder */
            const string strCmdText = "/K cd Server&node serb.js";

            Process.Start("CMD", strCmdText);
            RunGame();
        }

        public static void QuitButton()
        {
            Application.Current.Shutdown();
        }
    }
}
