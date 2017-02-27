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
using System.Windows.Threading;

namespace Projekat2
{
    /// <summary>
    /// Interaction logic for Igra.xaml
    /// </summary>
    public partial class Igra : Page
    {
        int red=0;
        int kol=0;
        int mod;
        int pobeda=0;
        Image[,] mat_pokusaji;
        Image[,] mat_rezultati;
        Button[] mat_kontrole;
        Image[] kombinacija;
        string[] slike = {
            "pack://application:,,,/Projekat2;component/Images/pik.png",
            "pack://application:,,,/Projekat2;component/Images/karo.png",
            "pack://application:,,,/Projekat2;component/Images/srce.png",
            "pack://application:,,,/Projekat2;component/Images/tref.png",
            "pack://application:,,,/Projekat2;component/Images/zvezda.png",
            "pack://application:,,,/Projekat2;component/Images/Csharp.png" };
        private int sivi=0;
        private int crni=0;
        DispatcherTimer timer = new DispatcherTimer();

        public Igra(int mod)
        {
            InitializeComponent();
            this.mod = mod;

            mat_pokusaji = new Image[6, mod + 3];
            mat_rezultati = new Image[6, mod + 3];
           kombinacija=new Image[3+mod];
            mat_kontrole = new Button[ 6];
            postavljanje_kontrola();
            postavljanje_pokusaja();
            postavljanje_rezultata();
            kombinacija = kombinacijaGen();
            
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();           
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
             double korak = panel.ActualHeight / 120.0;
            
             vreme.Height += korak;
            if (Math.Ceiling(panel.ActualHeight)==Math.Ceiling(vreme.Height) ||
                Math.Ceiling(panel.ActualHeight) < Math.Ceiling(vreme.Height)) {
                timer.Stop();
                postavi_resenje();
            }
            if (pobeda == 1) timer.Stop();
        }

        private Image[] kombinacijaGen()
        {
            string str="";
            Random gen = new Random();
            for (int i = 0; i < 3+mod; i++)
            {
                kombinacija[i] = new Image();
                kombinacija[i].Source = ImageInit(slike[gen.Next(6)]);
                str +=kombinacija[i].Source.ToString()+"\n";
            }
            MessageBox.Show(str);
            return kombinacija;

        }

        private void postavljanje_rezultata()
        {
            for (int i = 0; i < 6; i++)
                rezultati.RowDefinitions.Add(new RowDefinition());
            for (int j = 0; j < 3 + mod; j++)
                rezultati.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 3 + mod; j++)
                {
                    mat_rezultati[i, j] = new Image();
                    mat_rezultati[i, j].Source = ImageInit("Images/okvir_pogodaka.png");
                    Grid.SetColumn(mat_rezultati[i, j], j);
                    Grid.SetRow(mat_rezultati[i, j], i);
                    rezultati.Children.Add(mat_rezultati[i, j]);
                }
        
    }

        private void postavljanje_pokusaja()
        {
            for (int i = 0; i < 6; i++)
                pokusaji.RowDefinitions.Add(new RowDefinition());
            for (int j = 0; j < 3 + mod; j++)
                pokusaji.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 3 + mod; j++)
                {
                    mat_pokusaji[i, j] = new Image();
                    mat_pokusaji[i, j].Source = ImageInit("Images/okvir_pokusaja.png");
                    Grid.SetColumn(mat_pokusaji[i, j], j);
                    Grid.SetRow(mat_pokusaji[i, j], i);
                    pokusaji.Children.Add(mat_pokusaji[i, j]);
                }
        }

        private void postavljanje_kontrola()
        {

            kontrole.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < 6; i++)
            {
                kontrole.ColumnDefinitions.Add(new ColumnDefinition());
                mat_kontrole[i] = new Button();
                Image img = new Image();
                img.Source = ImageInit(slike[i]);
                mat_kontrole[i].Content =img;
                mat_kontrole[i].Click += kontrole_Click;
                Grid.SetColumn(mat_kontrole[i], i);
                Grid.SetRow(mat_kontrole[i], 0);

                kontrole.Children.Add(mat_kontrole[i]);
            }

        }

        private void kontrole_Click(object sender, RoutedEventArgs e)
        {
            if (kol != 3 + mod)
           
            {
                kontrola_sound.Play();
                
                Image img = new Image();
                img.Source = ((sender as Button).Content as Image).Source;
                mat_pokusaji[red, kol] = img;

                postavi_pokusaj(red, kol);
                kol++;
            }
            
            
        }

        private void postavi_pokusaj(int i, int j)
        {

            Grid.SetColumn(mat_pokusaji[i, j], j);
            Grid.SetRow(mat_pokusaji[i, j], i);
            pokusaji.Children.Add(mat_pokusaji[i, j]);
        }

        private void postavi_rezultat(int i, int j)
        {
            Grid.SetColumn(mat_rezultati[i, j], j);
            Grid.SetRow(mat_rezultati[i, j], i);
            rezultati.Children.Add(mat_rezultati[i, j]);
        }

        private ImageSource ImageInit(string s)
        {
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri(s, UriKind.RelativeOrAbsolute);
            bit.EndInit();
            return bit;
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {
            dugme_sound.Play();
            if (potvrdi.Content.ToString().Equals("OK"))
            {

                if (pobeda == 1)
                {
                    int skor;
                    skor = (mod * 100 * (7 - red))+ Convert.ToInt32(panel.ActualHeight/vreme.ActualHeight)*100;

                    NavigationService.Navigate(new Pobeda(skor,mod));
                }
                else
                    NavigationService.Navigate(new Poraz());

            }
            else if (kol != 3 + mod) { MessageBox.Show("Morate uneti punu kombinaciju"); }
            else
            {
                for (int i = 0; i < mod + 3; i++)
                    if ((mat_pokusaji[red, i] as Image).Source.ToString().Equals(kombinacija[i].Source.ToString()))
                    {
                        crni++;
                    }
                for (int i = 0; i < mod + 3; i++)
                    for (int j = 0; j < mod + 3; j++)
                    {
                        if ((mat_pokusaji[red, i] as Image).Source.ToString().Equals(kombinacija[j].Source.ToString())
                                        && !mat_pokusaji[red, i].Name.Equals("fleg") && !kombinacija[j].Name.Equals("fleg"))
                        {
                            mat_pokusaji[red, i].Name = "fleg";
                            kombinacija[j].Name = "fleg";
                            sivi++;
                        }
                    }
               
                if(crni==mod+3)
                { potvrdi.Content = "OK";pobeda = 1;
                    pobeda_sound.Play();
                    izbrisi.Visibility = Visibility.Collapsed;

                }
                ispisi_rezultat();

                if ((red == 5 && kol == 3 + mod) || crni==mod+3)
                {
                    postavi_resenje();
                    
                }
                red++;
                kol = 0;
                crni = 0;
                sivi = 0;


            }
           

            for (int j = 0; j < mod + 3; j++)
                kombinacija[j].Name = "nonfleg";
        }

        private void postavi_resenje() {
            kontrole.Children.Clear();
            lab.Visibility = Visibility.Visible;
            if (mod == 1)
            {
                kontrole.ColumnDefinitions.RemoveAt(0);
                kontrole.ColumnDefinitions.RemoveAt(0);
            }
            if (mod == 2)
            {
                kontrole.ColumnDefinitions.RemoveAt(0);
            }
            for (int i = 0; i < mod + 3; i++)
            {
                Image img = new Image();
                img.Source = ImageInit(kombinacija[i].Source.ToString());
                Grid.SetColumn(img, i);
                Grid.SetRow(img, 0);
                kontrole.Children.Add(img);
            }
            izbrisi.Visibility = Visibility.Collapsed;
            potvrdi.Content = "OK";
        }

        private void ispisi_rezultat()
        {
            for (int i = 0; i < crni; i++)
            {
                Image img = new Image();
                img.Source = ImageInit("Images/mesto_znak.png");
                mat_rezultati[red, i] = img;
                postavi_rezultat(red,i);
            }
            for (int i = crni; i < sivi; i++)
            {
                Image img = new Image();
                img.Source = ImageInit("Images/znak.png");
                mat_rezultati[red, i] = img;
                postavi_rezultat(red, i);
            }
        }

        private void izbrisi_Click(object sender, RoutedEventArgs e)
        {
            if ( (kol!=0)) {
                dugme_sound.Play();
                pokusaji.Children.RemoveAt(pokusaji.Children.Count - 1);
                kol--;
            }
            
            
        }

        private void sound_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Stop();
        }

     
    }
}
