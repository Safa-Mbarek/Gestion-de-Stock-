using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Contrelleur;
using System.Globalization;

namespace Views
{
    public partial class GestionProduis : Form
    {
        public GestionProduis()
        {
            InitializeComponent();
        }

        void Reload()
        {
            dgv_Produits.Rows.Clear();
            ProduitControlleur produitControlleur = new ProduitControlleur();
            List<Produit> produits = produitControlleur.GetProduits();
            foreach (Produit produit in produits)
            {
                dgv_Produits.Rows.Add(produit.Reference, produit.Designiation, produit.Qte, produit.PrixAchat);
            }
        }
        private void GestionProduis_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void viderchamp()
        {
            referance.Text = design.Text = qte.Text = cmup.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (referance.Text == "")
            {
                MessageBox.Show("Ref invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (qte.Text == "" || Convert.ToInt32(qte.Text) <= 0)
            {
                MessageBox.Show("Qte invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmup.Text == "" || float.Parse(cmup.Text) <= 0)
            {
                MessageBox.Show("Prix invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produit produit = new Produit(referance.Text, design.Text, Convert.ToInt32(qte.Text), (float)Convert.ToDouble(cmup.Text, CultureInfo.InvariantCulture));
            ProduitControlleur pc = new ProduitControlleur();
            if (pc.AddProduit(produit))
            {
                dgv_Produits.Rows.Add(produit.Reference, produit.Designiation, produit.Qte, produit.PrixAchat);
                MessageBox.Show("Ajouter produit avec succer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viderchamp();
            }
            else
            {
                MessageBox.Show("Ce produit existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cherchref_Click(object sender, EventArgs e)
        {
            ProduitControlleur pc = new ProduitControlleur();
            dgv_Produits.Rows.Clear();
            foreach (Produit p in pc.GetProduits())
            {
                if (p.Reference == referance.Text)
                {
                    dgv_Produits.Rows.Add(p.Reference,p.Designiation,p.Qte,p.PrixAchat);
                    return;
                }
            }
        }

        private void relod_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
