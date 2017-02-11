using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
using System.Linq;
using System.Collections.ObjectModel;

namespace Projekat2
{
    /// <summary>
    /// Interaction logic for HighScores.xaml
    /// </summary>
    public partial class HighScores : Page
    {
        Data dat;
        public HighScores()
        {   InitializeComponent();
            dat = new Data();
            if(File.Exists("HighScores.bin"))
            dat = Data.Deserijalizuj();
            dat.Sort(dat.GetSetEasy);
            dat.Sort(dat.GetSetNormal);
            dat.Sort(dat.GetSetHard);
            for (int i = 0; i < dat.GetSetEasy.Count; i++)
            {
                if (i > 9) dat.GetSetEasy.RemoveAt(i);
            }
            for (int i = 0; i < dat.GetSetNormal.Count; i++)
            {
                if (i > 9) dat.GetSetNormal.RemoveAt(i);
            }
            for (int i = 0; i < dat.GetSetHard.Count; i++)
            {
                if (i > 9) dat.GetSetHard.RemoveAt(i);
            }

        }


        private void back_Click(object sender, RoutedEventArgs e)
        {
            klik_sound.Play();
            NavigationService.Navigate(new StartPage());

        }

        private void tabela_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
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
                tabela.ItemsSource = dat.GetSetEasy;
                

            }
            else if (sender.Equals(normal))
            {
                normal.FontSize = 20;
                normal.Foreground = Brushes.Red;
                easy.FontSize = 12;
                hard.FontSize = 12;
                easy.Foreground = Brushes.Black;
                hard.Foreground = Brushes.Black;
                tabela.ItemsSource = dat.GetSetNormal;

                
            }
            else if (sender.Equals(hard))
            {
                hard.FontSize = 20;
                hard.Foreground = Brushes.Red;
                normal.FontSize = 12;
                easy.FontSize = 12;
                normal.Foreground = Brushes.Black;
                easy.Foreground = Brushes.Black;
                tabela.ItemsSource = dat.GetSetHard;

               
            }


        }

        private void klik_sound_MediaEnded(object sender, RoutedEventArgs e)
        {
            klik_sound.Stop();
        }
    }
}
