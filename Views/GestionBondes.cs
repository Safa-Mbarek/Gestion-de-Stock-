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
    public partial class GestionBondes : Form
    {
        public GestionBondes()
        {
            InitializeComponent();
        }

        void Reload()
        {
            dgv_Bond.Rows.Clear();
            cmb_Produits.Items.Clear();
            BondeController bondeController = new BondeController();
            string prefix = "BE";
            if (bs.Checked)
                prefix = "BS";
            num.Text = bondeController.GenerateCode(prefix, date.Value);

            ProduitControlleur produitControlleur = new ProduitControlleur();
            cmb_Produits.Items.AddRange(produitControlleur.GetProduits().ToArray());
            cmb_Produits.DisplayMember = "Reference";

            List<Bonde> bondes = bondeController.GetBondes();
            foreach (Bonde b in bondes)
            {
                dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
            }
        }
        private void GestionBondes_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void viderchamp()
        {
            num.Text = qte.Text = qte.Text = prixU.Text = "";
            date.Value = DateTime.Now;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(num.Text == "")
            {
                MessageBox.Show("Num invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(qte.Text == "" || Convert.ToInt32(qte.Text) <= 0)
            {
                MessageBox.Show("Qte invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (prixU.Text == "" || float.Parse(prixU.Text) <= 0)
            {
                MessageBox.Show("Prix invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmb_Produits.SelectedIndex == -1)
            {
                MessageBox.Show("Selectioner un produit!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (date.Value > DateTime.Now)
            {
                MessageBox.Show("Date invalide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string prefix = "BE";
            if (bs.Checked)
                prefix = "BS";
            Produit p = cmb_Produits.SelectedItem as Produit;
            Bonde b = new Bonde(num.Text, date.Value, prefix, Convert.ToInt32(qte.Text), (float)Convert.ToDouble(prixU.Text, CultureInfo.InvariantCulture), p);
            BondeController bc = new BondeController();
            ProduitControlleur produitControlleur = new ProduitControlleur();
            if (!produitControlleur.UpdateProduit(p, b))
            {
                MessageBox.Show("Qte insuffisante!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(!bc.AddBonde(b))
            {
                MessageBox.Show("Echec d'ajouter la bonde!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
                MessageBox.Show("Ajouter bonde avec succer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viderchamp();
                num.Text = bc.GenerateCode(prefix, date.Value);
            }
        }

        private void bs_CheckedChanged(object sender, EventArgs e)
        {
            BondeController bondeController = new BondeController();
            string prefix = "BS";
            num.Text = bondeController.GenerateCode(prefix, date.Value);
            lablePrix.Text = "Prix de vente";
        }

        private void be_CheckedChanged(object sender, EventArgs e)
        {
            BondeController bondeController = new BondeController();
            string prefix = "BE";
            num.Text = bondeController.GenerateCode(prefix, date.Value);
            lablePrix.Text = "Prix d'achat";
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            BondeController bc = new BondeController();
            string prefix = "BE";
            if (bs.Checked)
                prefix = "BS";
            num.Text = bc.GenerateCode(prefix, date.Value);
        }

        private void affBE_Click(object sender, EventArgs e)
        {
            BondeController bc = new BondeController();
            dgv_Bond.Rows.Clear();
            foreach(Bonde b in bc.GetBondes())
            {
                if(b.Type == "BE")
                {
                    dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
                }
            }
        }

        private void affBS_Click(object sender, EventArgs e)
        {
            BondeController bc = new BondeController();
            dgv_Bond.Rows.Clear();
            foreach (Bonde b in bc.GetBondes())
            {
                if (b.Type == "BS")
                {
                    dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
                }
            }
        }

        private void chercheNum_Click(object sender, EventArgs e)
        {
            BondeController bc = new BondeController();
            dgv_Bond.Rows.Clear();
            foreach (Bonde b in bc.GetBondes())
            {
                if (b.Date.ToShortDateString() == date.Value.ToShortDateString())
                {
                    dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
                }
            }
        }

        private void trieDate_Click(object sender, EventArgs e)
        {
            BondeController bc = new BondeController();
            dgv_Bond.Rows.Clear();
            var sortedList = bc.GetBondes().OrderByDescending(b => b.Date);
            foreach (Bonde b in sortedList)
            {
                dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
            }
        }

        private void archivBtn_Click(object sender, EventArgs e)
        {
            ProduitControlleur produitControlleur = new ProduitControlleur();
            BondeController bcontroller = new BondeController();
            foreach (DataGridViewRow row in dgv_Bond.SelectedRows)
            {
                Produit p = produitControlleur.GetProduitById(row.Cells[5].Value.ToString());
                Bonde b = new Bonde(row.Cells[0].Value.ToString(), DateTime.Parse(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString(), Convert.ToInt32(row.Cells[3].Value), (float)Convert.ToDouble(row.Cells[4].Value.ToString()), p);
                bcontroller.ArchiverBonde(b);
            }
            dgv_Bond.Rows.Clear();
            foreach (Bonde b in bcontroller.GetBondes())
            {
                dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
            }
        }

        private void dgv_Bond_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Bond.SelectedRows.Count > 0)
            {
                archivBtn.Enabled = true;
            }
            else
            {
                archivBtn.Enabled = false;
            }
        }

        private void relod_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}