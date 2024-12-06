namespace Views
{
    partial class GestionProduis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cherchref = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.design = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.referance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Produits = new System.Windows.Forms.DataGridView();
            this.dgv_ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_design = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_prixM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.relod);
            this.panel1.Controls.Add(this.cherchref);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.design);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.qte);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.referance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 440);
            this.panel1.TabIndex = 0;
            // 
            // cherchref
            // 
            this.cherchref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherchref.Location = new System.Drawing.Point(122, 320);
            this.cherchref.Name = "cherchref";
            this.cherchref.Size = new System.Drawing.Size(122, 42);
            this.cherchref.TabIndex = 9;
            this.cherchref.Text = "Cherche par ref";
            this.cherchref.UseVisualStyleBackColor = true;
            this.cherchref.Click += new System.EventHandler(this.cherchref_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(20, 320);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 42);
            this.add.TabIndex = 8;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // design
            // 
            this.design.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design.Location = new System.Drawing.Point(168, 76);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(162, 31);
            this.design.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Designation";
            // 
            // qte
            // 
            this.qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.Location = new System.Drawing.Point(168, 141);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(162, 31);
            this.qte.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantite";
            // 
            // cmup
            // 
            this.cmup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmup.Location = new System.Drawing.Point(168, 208);
            this.cmup.Name = "cmup";
            this.cmup.Size = new System.Drawing.Size(162, 31);
            this.cmup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PrixMoyenne";
            // 
            // referance
            // 
            this.referance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referance.Location = new System.Drawing.Point(168, 15);
            this.referance.Name = "referance";
            this.referance.Size = new System.Drawing.Size(162, 31);
            this.referance.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refferance";
            // 
            // dgv_Produits
            // 
            this.dgv_Produits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_Produits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_ref,
            this.dgv_design,
            this.dgv_qte,
            this.dgv_prixM});
            this.dgv_Produits.Location = new System.Drawing.Point(400, 12);
            this.dgv_Produits.Name = "dgv_Produits";
            this.dgv_Produits.Size = new System.Drawing.Size(529, 440);
            this.dgv_Produits.TabIndex = 1;
            // 
            // dgv_ref
            // 
            this.dgv_ref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ref.HeaderText = "Refferance";
            this.dgv_ref.Name = "dgv_ref";
            // 
            // dgv_design
            // 
            this.dgv_design.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_design.HeaderText = "Designation";
            this.dgv_design.Name = "dgv_design";
            // 
            // dgv_qte
            // 
            this.dgv_qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_qte.HeaderText = "Quantite";
            this.dgv_qte.Name = "dgv_qte";
            // 
            // dgv_prixM
            // 
            this.dgv_prixM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_prixM.HeaderText = "CUMP";
            this.dgv_prixM.Name = "dgv_prixM";
            // 
            // relod
            // 
            this.relod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relod.Location = new System.Drawing.Point(250, 320);
            this.relod.Name = "relod";
            this.relod.Size = new System.Drawing.Size(97, 42);
            this.relod.TabIndex = 18;
            this.relod.Text = "Actualiser";
            this.relod.UseVisualStyleBackColor = true;
            this.relod.Click += new System.EventHandler(this.relod_Click);
            // 
            // GestionProduis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 464);
            this.Controls.Add(this.dgv_Produits);
            this.Controls.Add(this.panel1);
            this.Name = "GestionProduis";
            this.Text = "GestionProduis";
            this.Load += new System.EventHandler(this.GestionProduis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox referance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox design;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_design;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_prixM;
        private System.Windows.Forms.Button cherchref;
        private System.Windows.Forms.Button relod;
    }
}