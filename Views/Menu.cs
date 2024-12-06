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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            GestionProduis gp = new GestionProduis();
            gp.MdiParent = this;
            gp.Show();
        }

        private void gestionBondesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            GestionBondes gb = new GestionBondes();
            gb.MdiParent = this;    
            gb.Show();
        }

        private void consulterArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ArchiverBonde gb = new ArchiverBonde();
            gb.MdiParent = this;
            gb.Show();
        }
    }
}
