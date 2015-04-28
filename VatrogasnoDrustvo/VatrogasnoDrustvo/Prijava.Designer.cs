namespace VatrogasnoDrustvo
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.lblDobrovoljnoVatrogasnoDrustvo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picLogo.Image = global::VatrogasnoDrustvo.Properties.Resources.Vatrogasci1;
            this.picLogo.Location = new System.Drawing.Point(226, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 151);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtKorIme
            // 
            this.txtKorIme.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKorIme.Location = new System.Drawing.Point(184, 268);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(216, 20);
            this.txtKorIme.TabIndex = 1;
            this.txtKorIme.Text = "Korisničko ime";
            this.txtKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLozinka
            // 
            this.txtLozinka.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLozinka.Location = new System.Drawing.Point(184, 294);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(216, 20);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.Text = "Lozinka";
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(257, 350);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.btnPrijaviSe.TabIndex = 3;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // lblDobrovoljnoVatrogasnoDrustvo
            // 
            this.lblDobrovoljnoVatrogasnoDrustvo.AutoSize = true;
            this.lblDobrovoljnoVatrogasnoDrustvo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrovoljnoVatrogasnoDrustvo.ForeColor = System.Drawing.Color.White;
            this.lblDobrovoljnoVatrogasnoDrustvo.Location = new System.Drawing.Point(88, 166);
            this.lblDobrovoljnoVatrogasnoDrustvo.Name = "lblDobrovoljnoVatrogasnoDrustvo";
            this.lblDobrovoljnoVatrogasnoDrustvo.Size = new System.Drawing.Size(433, 38);
            this.lblDobrovoljnoVatrogasnoDrustvo.TabIndex = 4;
            this.lblDobrovoljnoVatrogasnoDrustvo.Text = "Dobrovoljno Vatrogasno Društvo";
            // 
            // frmPrijava
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(603, 464);
            this.Controls.Add(this.lblDobrovoljnoVatrogasnoDrustvo);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrijava";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Label lblDobrovoljnoVatrogasnoDrustvo;
    }
}

