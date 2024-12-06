namespace Views
{
    partial class ArchiverBonde
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
            this.dgv_Bond = new System.Windows.Forms.DataGridView();
            this.dgv_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bond)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_Bond.Location = new System.Drawing.Point(147, 50);
            this.dgv_Bond.Name = "dgv_Bond";
            this.dgv_Bond.Size = new System.Drawing.Size(507, 351);
            this.dgv_Bond.TabIndex = 6;
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
            // ArchiverBonde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Bond);
            this.Name = "ArchiverBonde";
            this.Text = "ArchiverBonde";
            this.Load += new System.EventHandler(this.ArchiverBonde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bond;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_produit;
    }
}