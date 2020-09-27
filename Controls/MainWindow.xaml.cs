using System.IO;
using System.Windows;
using System.Windows.Input;

namespace GMLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //if (!File.Exists(@"E:\SteamLibrary\steamapps\common\HITMAN2\Server\serb.js"))
            if (!File.Exists(@"Server\serb.js"))
            {
                ServerButton.IsEnabled = false;
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayButton();
        }

        private void ServerButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.ServerButton();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.QuitButton();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}