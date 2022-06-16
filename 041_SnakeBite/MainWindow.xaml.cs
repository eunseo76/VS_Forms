using System.Windows;

namespace _041_SnakeBite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
