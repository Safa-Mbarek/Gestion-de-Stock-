namespace Views
{
    partial class GestionBondes
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
            this.cmb_Produits = new System.Windows.Forms.ComboBox();
            this.bs = new System.Windows.Forms.RadioButton();
            this.be = new System.Windows.Forms.RadioButton();
            this.chercheNum = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.prixU = new System.Windows.Forms.TextBox();
            this.lablePrix = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Bond = new System.Windows.Forms.DataGridView();
            this.dgv_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieDate = new System.Windows.Forms.Button();
            this.affBS = new System.Windows.Forms.Button();
            this.affBE = new System.Windows.Forms.Button();
            this.archivBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.relod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bond)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.relod);
            this.panel1.Controls.Add(this.cmb_Produits);
            this.panel1.Controls.Add(this.bs);
            this.panel1.Controls.Add(this.be);
            this.panel1.Controls.Add(this.chercheNum);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.prixU);
            this.panel1.Controls.Add(this.lablePrix);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.qte);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.num);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 425);
            this.panel1.TabIndex = 4;
            // 
            // cmb_Produits
            // 
            this.cmb_Produits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_Produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Produits.FormattingEnabled = true;
            this.cmb_Produits.Location = new System.Drawing.Point(168, 275);
            this.cmb_Produits.Name = "cmb_Produits";
            this.cmb_Produits.Size = new System.Drawing.Size(162, 33);
            this.cmb_Produits.TabIndex = 16;
            // 
            // bs
            // 
            this.bs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bs.AutoSize = true;
            this.bs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs.Location = new System.Drawing.Point(250, 129);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(51, 24);
            this.bs.TabIndex = 15;
            this.bs.Text = "BS";
            this.bs.UseVisualStyleBackColor = true;
            this.bs.CheckedChanged += new System.EventHandler(this.bs_CheckedChanged);
            // 
            // be
            // 
            this.be.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.be.AutoSize = true;
            this.be.Checked = true;
            this.be.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.be.Location = new System.Drawing.Point(168, 129);
            this.be.Name = "be";
            this.be.Size = new System.Drawing.Size(51, 24);
            this.be.TabIndex = 14;
            this.be.TabStop = true;
            this.be.Text = "BE";
            this.be.UseVisualStyleBackColor = true;
            this.be.CheckedChanged += new System.EventHandler(this.be_CheckedChanged);
            // 
            // chercheNum
            // 
            this.chercheNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercheNum.Location = new System.Drawing.Point(148, 341);
            this.chercheNum.Name = "chercheNum";
            this.chercheNum.Size = new System.Drawing.Size(122, 42);
            this.chercheNum.TabIndex = 10;
            this.chercheNum.Text = "Cherche par date";
            this.chercheNum.UseVisualStyleBackColor = true;
            this.chercheNum.Click += new System.EventHandler(this.chercheNum_Click);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(168, 72);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(162, 20);
            this.date.TabIndex = 13;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Produit";
            // 
            // prixU
            // 
            this.prixU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prixU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixU.Location = new System.Drawing.Point(168, 223);
            this.prixU.Name = "prixU";
            this.prixU.Size = new System.Drawing.Size(162, 31);
            this.prixU.TabIndex = 10;
            // 
            // lablePrix
            // 
            this.lablePrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lablePrix.AutoSize = true;
            this.lablePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePrix.Location = new System.Drawing.Point(15, 223);
            this.lablePrix.Name = "lablePrix";
            this.lablePrix.Size = new System.Drawing.Size(136, 25);
            this.lablePrix.TabIndex = 9;
            this.lablePrix.Text = "Prix d\'achat";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(20, 341);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 42);
            this.add.TabIndex = 8;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // qte
            // 
            this.qte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.Location = new System.Drawing.Point(168, 172);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(162, 31);
            this.qte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantite";
            // 
            // num
            // 
            this.num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num.Enabled = false;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(168, 15);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(162, 31);
            this.num.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // dgv_Bond
            // 
            this.dgv_Bond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_Bond.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Bond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_num,
            this.dgv_date,
            this.dgv_type,
            this.dgv_qte,
            this.dgv_prix,
            this.dgv_produit});
            this.dgv_Bond.Location = new System.Drawing.Point(417, 8);
            this.dgv_Bond.Name = "dgv_Bond";
            this.dgv_Bond.Size = new System.Drawing.Size(507, 351);
            this.dgv_Bond.TabIndex = 5;
            this.dgv_Bond.SelectionChanged += new System.EventHandler(this.dgv_Bond_SelectionChanged);
            // 
            // dgv_num
            // 
            this.dgv_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_num.HeaderText = "Numero";
            this.dgv_num.Name = "dgv_num";
            // 
            // dgv_date
            // 
            this.dgv_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_date.HeaderText = "Date";
            this.dgv_date.Name = "dgv_date";
            // 
            // dgv_type
            // 
            this.dgv_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_type.HeaderText = "Type";
            this.dgv_type.Name = "dgv_type";
            // 
            // dgv_qte
            // 
            this.dgv_qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_qte.HeaderText = "Quantite";
            this.dgv_qte.Name = "dgv_qte";
            // 
            // dgv_prix
            // 
            this.dgv_prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_prix.HeaderText = "Prix unite";
            this.dgv_prix.Name = "dgv_prix";
            // 
            // dgv_produit
            // 
            this.dgv_produit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_produit.HeaderText = "Produit";
            this.dgv_produit.Name = "dgv_produit";
            // 
            // trieDate
            // 
            this.trieDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trieDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trieDate.Location = new System.Drawing.Point(417, 389);
            this.trieDate.Name = "trieDate";
            this.trieDate.Size = new System.Drawing.Size(122, 42);
            this.trieDate.TabIndex = 9;
            this.trieDate.Text = "Trier par date";
            this.trieDate.UseVisualStyleBackColor = true;
            this.trieDate.Click += new System.EventHandler(this.trieDate_Click);
            // 
            // affBS
            // 
            this.affBS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.affBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affBS.Location = new System.Drawing.Point(546, 389);
            this.affBS.Name = "affBS";
            this.affBS.Size = new System.Drawing.Size(122, 42);
            this.affBS.TabIndex = 11;
            this.affBS.Text = "BS";
            this.affBS.UseVisualStyleBackColor = true;
            this.affBS.Click += new System.EventHandler(this.affBS_Click);
            // 
            // affBE
            // 
            this.affBE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.affBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affBE.Location = new System.Drawing.Point(674, 389);
            this.affBE.Name = "affBE";
            this.affBE.Size = new System.Drawing.Size(122, 42);
            this.affBE.TabIndex = 12;
            this.affBE.Text = "BE";
            this.affBE.UseVisualStyleBackColor = true;
            this.affBE.Click += new System.EventHandler(this.affBE_Click);
            // 
            // archivBtn
            // 
            this.archivBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.archivBtn.Enabled = false;
            this.archivBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivBtn.Location = new System.Drawing.Point(803, 389);
            this.archivBtn.Name = "archivBtn";
            this.archivBtn.Size = new System.Drawing.Size(122, 42);
            this.archivBtn.TabIndex = 13;
            this.archivBtn.Text = "Archiver";
            this.archivBtn.UseVisualStyleBackColor = true;
            this.archivBtn.Click += new System.EventHandler(this.archivBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.archivBtn);
            this.panel2.Controls.Add(this.dgv_Bond);
            this.panel2.Controls.Add(this.affBE);
            this.panel2.Controls.Add(this.affBS);
            this.panel2.Controls.Add(this.trieDate);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 437);
            this.panel2.TabIndex = 14;
            // 
            // relod
            // 
            this.relod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relod.Location = new System.Drawing.Point(276, 341);
            this.relod.Name = "relod";
            this.relod.Size = new System.Drawing.Size(97, 42);
            this.relod.TabIndex = 17;
            this.relod.Text = "Actualiser";
            this.relod.UseVisualStyleBackColor = true;
            this.relod.Click += new System.EventHandler(this.relod_Click);
            // 
            // GestionBondes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.panel2);
            this.Name = "GestionBondes";
            this.Text = "GestionBondes";
            this.Load += new System.EventHandler(this.GestionBondes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bond)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Produits;
        private System.Windows.Forms.RadioButton bs;
        private System.Windows.Forms.RadioButton be;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prixU;
        private System.Windows.Forms.Label lablePrix;
        private System.Windows.Forms.DataGridView dgv_Bond;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_produit;
        private System.Windows.Forms.Button chercheNum;
        private System.Windows.Forms.Button trieDate;
        private System.Windows.Forms.Button affBS;
        private System.Windows.Forms.Button affBE;
        private System.Windows.Forms.Button archivBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button relod;
    }
}