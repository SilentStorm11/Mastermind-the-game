using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    [Serializable]
    class Rezultat : IComparable
    {
        string user;
        int score;
        
        public Rezultat(string ime,int skor) {
            user = ime;
            score = skor;
        }
      
        public string Name
        {
            get { return user; }
            set { this.user = value; }
        }
        
        public int Score
        {
            get { return score; }
            set { this.score = value; }
        }

        public int CompareTo(object obj)
        {
            Rezultat a = this;
            Rezultat b = (Rezultat)obj;
            if (a.score > b.score)
                return -1;
            else if (a.score == b.score)
                return 0;
            else return 1;
        }
    }
}
