using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace GMLauncher
{
    class Launcher
    {
        public static void RunGame()
        {
            try
            {
                Process.Start("steam://rungameid/863550");
                Thread.Sleep(1000);
                Process.Start("Hitman2Patcher.exe");
                Application.Current.Shutdown();

                /* WIP:
                 * Launcher could remain running and checking if game process is terminated,
                 * to then close all the other windows automatically.
                 * 
                 * Application.Current.MainWindow.ShowInTaskbar = false;
                 * Application.Current.MainWindow.Hide();
                 */
            }
            catch (System.Exception)
            {
                Application.Current.MainWindow.Activate();
                Application.Current.MainWindow.Topmost = true;
                Application.Current.MainWindow.Focus();
                MessageBoxResult result =
                    MessageBox.Show("Both GMLauncher.exe and Hitman2Patcher.exe must be inside the Server folder.", "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                switch (result)
                {
                    case MessageBoxResult.OK:
                        Application.Current.MainWindow.Topmost = false;
                        break;
                }
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
            const string strCmdText = "/K node serb.js";
            Process.Start("CMD", strCmdText);
            RunGame();
        }

        public static void QuitButton()
        {
            Application.Current.Shutdown();
        }
    }
}
