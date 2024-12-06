using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bonde
    {
        private string num;
        private DateTime date;
        private string type;
        private int qte;
        private float prix;
        private Produit produit;

        public Bonde(string num, DateTime date, string type, int qte, float prix, Produit produit)
        {
            this.num = num;
            this.date = date;
            this.type = type;
            this.qte = qte;
            this.prix = prix;
            this.produit = produit;
        }

        public string Num { get => num; set => num = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public int Qte { get => qte; set => qte = value; }
        public float Prix { get => prix; set => prix = value; }
        public Produit Produit { get => produit; set => produit = value; }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (this == other) return true;
            if (!(other is Bonde)) return false;
            Bonde obj = (Bonde)other;
            return obj.num.Equals(num);
        }

        public override string ToString()
        {
            return num + "," + date + "," + type + "," + qte + "," + prix + "," + produit;
        }
    }
}
