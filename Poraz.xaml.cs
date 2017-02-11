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
    /// Interaction logic for Poraz.xaml
    /// </summary>
    public partial class Poraz : Page
    {
        public Poraz()
        {
            InitializeComponent();
        }

        private void skorovi_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();
            NavigationService.Navigate(new HighScores());

        }

        private void try_again_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();
            NavigationService.Navigate(new StartPage());

        }

        private void klik_sound_MediaEnded(object sender, RoutedEventArgs e)
        {
            klik_sound.Stop();
        }
    }
}
