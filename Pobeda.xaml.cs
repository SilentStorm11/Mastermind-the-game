using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// Interaction logic for Pobeda.xaml
    /// </summary>
    public partial class Pobeda : Page
    {
        int skor;
        int mod;
        public Pobeda(int skor,int mod)
        {
            this.mod = mod;
            this.skor = skor;

            InitializeComponent();
            lab.Content = lab.Content + " Your Score Is: "+ skor + "pts";

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

        private void sacuvaj_Click(object sender, RoutedEventArgs e)
        {

            klik_sound.Play();
            Rezultat rezultat = new Rezultat(ime.Text, skor);
            
            Data dat = new Data();
            if(File.Exists("HighScores.bin"))
                dat =Data.Deserijalizuj();
            if (mod == 1) { dat.GetSetEasy.Add(rezultat); }
            else if (mod == 2) { dat.GetSetNormal.Add(rezultat); }
            else { dat.GetSetHard.Add(rezultat); }

            Data.Serijalizuj(dat);
            MessageBox.Show("Uspesno ste sacuvali rezultat "+ime.Text);
            sacuvaj.IsEnabled = false;
            ime.Clear();
        }

        private void klik_sound_MediaEnded(object sender, RoutedEventArgs e)
        {
            klik_sound.Stop();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!sacuvaj.IsEnabled) sacuvaj.IsEnabled = true;

        }
    }
}
