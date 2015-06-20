namespace VatrogasnoDrustvo.Forms
{
    partial class PodaciRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodaciRegistracija));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRegistracijaNaslov = new System.Windows.Forms.Label();
            this.lblPodaciClanaPrezime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.cmbClanovi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(224, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(224, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 20);
            this.txtUsername.TabIndex = 17;
            // 
            // lblRegistracijaNaslov
            // 
            this.lblRegistracijaNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistracijaNaslov.AutoSize = true;
            this.lblRegistracijaNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracijaNaslov.ForeColor = System.Drawing.Color.White;
            this.lblRegistracijaNaslov.Location = new System.Drawing.Point(118, 37);
            this.lblRegistracijaNaslov.Name = "lblRegistracijaNaslov";
            this.lblRegistracijaNaslov.Size = new System.Drawing.Size(265, 37);
            this.lblRegistracijaNaslov.TabIndex = 16;
            this.lblRegistracijaNaslov.Text = "Registracija korisnika";
            // 
            // lblPodaciClanaPrezime
            // 
            this.lblPodaciClanaPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPodaciClanaPrezime.AutoSize = true;
            this.lblPodaciClanaPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciClanaPrezime.ForeColor = System.Drawing.Color.White;
            this.lblPodaciClanaPrezime.Location = new System.Drawing.Point(120, 180);
            this.lblPodaciClanaPrezime.Name = "lblPodaciClanaPrezime";
            this.lblPodaciClanaPrezime.Size = new System.Drawing.Size(86, 25);
            this.lblPodaciClanaPrezime.TabIndex = 15;
            this.lblPodaciClanaPrezime.Text = "Lozinka:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(61, 133);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 25);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistriraj.Location = new System.Drawing.Point(224, 295);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(88, 28);
            this.btnRegistriraj.TabIndex = 19;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // cmbClanovi
            // 
            this.cmbClanovi.FormattingEnabled = true;
            this.cmbClanovi.Location = new System.Drawing.Point(224, 234);
            this.cmbClanovi.Name = "cmbClanovi";
            this.cmbClanovi.Size = new System.Drawing.Size(194, 21);
            this.cmbClanovi.TabIndex = 20;
            // 
            // PodaciRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(506, 349);
            this.Controls.Add(this.cmbClanovi);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRegistracijaNaslov);
            this.Controls.Add(this.lblPodaciClanaPrezime);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodaciRegistracija";
            this.Text = "PodaciRegistracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRegistracijaNaslov;
        private System.Windows.Forms.Label lblPodaciClanaPrezime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.ComboBox cmbClanovi;
    }
}