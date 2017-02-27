using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    [Serializable]
    class Data 
    {
        
        private ObservableCollection<Rezultat> lista_easy = new ObservableCollection<Rezultat>();
        private ObservableCollection<Rezultat> lista_hard = new ObservableCollection<Rezultat>();
        private ObservableCollection<Rezultat> lista_normal = new ObservableCollection<Rezultat>();

        public void Sort<Rezultat>(ObservableCollection<Rezultat> collection) where Rezultat : IComparable
        {
            //  List<Rezultat> sorted = collection.OrderBy(x => x).ToList();
            //for (int i = 0; i < sorted.Count(); i++)
            //  collection.Move(collection.IndexOf(sorted[i]), i);
        }


        public ObservableCollection<Rezultat> GetSetEasy
        {
            get { return lista_easy; }
            set { lista_easy = value; }
        }
        public ObservableCollection<Rezultat> GetSetNormal
        {
            get { return lista_normal; }
            set { lista_normal = value; }
        }
        public ObservableCollection<Rezultat> GetSetHard
        {
            get { return lista_hard; }
            set { lista_hard = value; }
        }

        // File f = new File("HighScores.bin");
        public static void Serijalizuj(Data dat) {
            string putanja = "HighScores.bin";

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(putanja);
            bf.Serialize(fs, dat);
            fs.Dispose();
        }
        public static Data Deserijalizuj() {
            string putanja = "HighScores.bin";

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead(putanja);
            Data dat = new Data();
            dat = bf.Deserialize(fs) as Data;
            fs.Dispose();
            return dat;
        }
            
            }
    }

