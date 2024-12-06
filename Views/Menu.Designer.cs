namespace Views
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bondesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBondesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem,
            this.bondesToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitToolStripMenuItem.Text = "Produits";
            // 
            // gestionProduitToolStripMenuItem
            // 
            this.gestionProduitToolStripMenuItem.Name = "gestionProduitToolStripMenuItem";
            this.gestionProduitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.gestionProduitToolStripMenuItem.Text = "Gestion Produits";
            this.gestionProduitToolStripMenuItem.Click += new System.EventHandler(this.gestionProduitToolStripMenuItem_Click);
            // 
            // bondesToolStripMenuItem
            // 
            this.bondesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionBondesToolStripMenuItem});
            this.bondesToolStripMenuItem.Name = "bondesToolStripMenuItem";
            this.bondesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.bondesToolStripMenuItem.Text = "Bondes";
            // 
            // gestionBondesToolStripMenuItem
            // 
            this.gestionBondesToolStripMenuItem.Name = "gestionBondesToolStripMenuItem";
            this.gestionBondesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionBondesToolStripMenuItem.Text = "Gestion bondes";
            this.gestionBondesToolStripMenuItem.Click += new System.EventHandler(this.gestionBondesToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterArchiveToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // consulterArchiveToolStripMenuItem
            // 
            this.consulterArchiveToolStripMenuItem.Name = "consulterArchiveToolStripMenuItem";
            this.consulterArchiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consulterArchiveToolStripMenuItem.Text = "Consulter archive";
            this.consulterArchiveToolStripMenuItem.Click += new System.EventHandler(this.consulterArchiveToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bondesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionBondesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterArchiveToolStripMenuItem;
    }
}

