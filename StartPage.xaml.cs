using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekat2
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        int mod = 0;
        public StartPage()
        {
            InitializeComponent();

        }

        private void igra_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();
            if (!tezine.IsVisible)
            {
                lab.Visibility = Visibility.Visible;
                tezine.Visibility = Visibility.Visible;
                igra.Content = "START";
            }
            else if (mod == 0)
            {
                lab.Visibility = Visibility.Collapsed;
                tezine.Visibility = Visibility.Collapsed;
                igra.Content = "Nova Igra";
                MessageBox.Show("Izaberite tezinu igre");
            }
            else
            {
                NavigationService.Navigate(new Igra(mod));
            }


        }

        private void biranjeTezine(object sender, MouseButtonEventArgs e)
        {
            klik_sound.Play();
            
            if (sender.Equals(easy))
            {
                easy.FontSize = 20;
                easy.Foreground = Brushes.Red;
                normal.FontSize = 12;
                hard.FontSize = 12;
                normal.Foreground = Brushes.Black;
                hard.Foreground = Brushes.Black;

                mod = 1;

            }
            else if (sender.Equals(normal))
            {
                normal.FontSize = 20;
                normal.Foreground = Brushes.Red;
                easy.FontSize = 12;
                hard.FontSize = 12;
                easy.Foreground = Brushes.Black;
                hard.Foreground = Brushes.Black;
                mod = 2;
            }
            else if (sender.Equals(hard))
            {
                hard.FontSize = 20;
                hard.Foreground = Brushes.Red;
                normal.FontSize = 12;
                easy.FontSize = 12;
                normal.Foreground = Brushes.Black;
                easy.Foreground = Brushes.Black;
                mod = 3;
            }


        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();
            Environment.Exit(0);
           // Application.Current.Shutdown();
        }

        private void rezultati_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();

            NavigationService.Navigate(new HighScores());

        }

        private void klik_sound_MediaEnded(object sender, RoutedEventArgs e)
        {
            klik_sound.Stop();
        }
    }
}
