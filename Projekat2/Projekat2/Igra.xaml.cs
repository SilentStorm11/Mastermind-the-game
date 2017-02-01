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
    /// Interaction logic for Igra.xaml
    /// </summary>
    public partial class Igra : Page
    {
        int red=0;
        int kol=0;
        int mod;
        Image[,] mat_pokusaji;
        Image[,] mat_rezultati;
        Button[] mat_kontrole;
        Image[] kombinacija;
        string[] slike = { "Images/pik.png", "Images/karo.png", "Images/srce.png", "Images/tref.png", "Images/zvezda.png", "Images/Csharp.png" };

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

           
            


           
            

        }

        private Image[] kombinacijaGen()
        {
            Random gen = new Random();
            for (int i = 0; i < 3+mod; i++)
            {
                kombinacija[i] = new Image();
                kombinacija[i].Source = ImageInit(slike[gen.Next(3+mod)]);

            }
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
            if(kol==3+mod)
            { red++;kol = 0; }
            if (red == 5&&kol==2+mod)
            { kontrole.Children.Clear(); }
            Image img = new Image();
            img.Source= ((sender as Button).Content as Image).Source;
            mat_pokusaji[red, kol] = img; 

            postavi_pokusaj(red,kol);
            kol++;
            
        }

        private ImageSource ImageInit(string s)
        {
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri(s, UriKind.RelativeOrAbsolute);
            bit.EndInit();
            return bit;
        }

       private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void potvrdi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void postavi_pokusaj(int i,int j) {

            Grid.SetColumn(mat_pokusaji[i, j], j);
            Grid.SetRow(mat_pokusaji[i, j], i);
            pokusaji.Children.Add(mat_pokusaji[i, j]);
        }

        private void izbrisi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
