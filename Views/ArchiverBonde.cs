using Contrelleur;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ArchiverBonde : Form
    {
        public ArchiverBonde()
        {
            InitializeComponent();
        }

        private void ArchiverBonde_Load(object sender, EventArgs e)
        {
            BondeController bondeController = new BondeController();
            List<Bonde> bondes = bondeController.GetArchive();
            foreach (Bonde b in bondes)
            {
                dgv_Bond.Rows.Add(b.Num, b.Date, b.Type, b.Qte, b.Prix, b.Produit.Reference);
            }
        }
    }
}
