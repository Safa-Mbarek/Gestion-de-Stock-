using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class Produit
    {
        private string reference;
        private string designiation;
        private int qte;
        private float prixAchat;

        public Produit(string reference, string designiation, int qte, float prixAchat)
        {
            this.reference = reference;
            this.designiation = designiation;
            this.qte = qte;
            this.prixAchat = prixAchat;
        }

        public string Reference { get => reference; set => reference = value; }
        public string Designiation { get => designiation; set => designiation = value; }
        public int Qte { get => qte; set => qte = value; }
        public float PrixAchat { get => prixAchat; set => prixAchat = value; }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (this == other) return true;
            if (!(other is Produit)) return false;
            Produit obj = (Produit)other;
            return obj.reference.Equals(reference);
        }

        public override string ToString()
        {
            return reference + "," + designiation + "," + qte + "," + prixAchat;
        }
    }
}
