namespace VatrogasnoDrustvo.Controls
{
    /**
     * Kontrola za panel pri ulasku korisnika u sustav.
     */
    partial class MainPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblZvanje = new System.Windows.Forms.Label();
            this.lblStaticZvanje = new System.Windows.Forms.Label();
            this.lblPrijavljenIme = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlGlavna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGlavna.BackColor = System.Drawing.Color.Firebrick;
            this.pnlGlavna.Controls.Add(this.lblDobrodosli);
            this.pnlGlavna.Controls.Add(this.lblZvanje);
            this.pnlGlavna.Controls.Add(this.lblStaticZvanje);
            this.pnlGlavna.Controls.Add(this.lblPrijavljenIme);
            this.pnlGlavna.Controls.Add(this.picLogo);
            this.pnlGlavna.Location = new System.Drawing.Point(0, 0);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(997, 481);
            this.pnlGlavna.TabIndex = 1;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobrodosli.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDobrodosli.Location = new System.Drawing.Point(333, 245);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(351, 75);
            this.lblDobrodosli.TabIndex = 4;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // lblZvanje
            // 
            this.lblZvanje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblZvanje.AutoSize = true;
            this.lblZvanje.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblZvanje.Location = new System.Drawing.Point(499, 459);
            this.lblZvanje.Name = "lblZvanje";
            this.lblZvanje.Size = new System.Drawing.Size(61, 13);
            this.lblZvanje.TabIndex = 3;
            this.lblZvanje.Text = "Vatrogasac";
            // 
            // lblStaticZvanje
            // 
            this.lblStaticZvanje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStaticZvanje.AutoSize = true;
            this.lblStaticZvanje.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStaticZvanje.Location = new System.Drawing.Point(450, 459);
            this.lblStaticZvanje.Name = "lblStaticZvanje";
            this.lblStaticZvanje.Size = new System.Drawing.Size(43, 13);
            this.lblStaticZvanje.TabIndex = 2;
            this.lblStaticZvanje.Text = "Zvanje:";
            // 
            // lblPrijavljenIme
            // 
            this.lblPrijavljenIme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPrijavljenIme.AutoSize = true;
            this.lblPrijavljenIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijavljenIme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrijavljenIme.Location = new System.Drawing.Point(446, 424);
            this.lblPrijavljenIme.Name = "lblPrijavljenIme";
            this.lblPrijavljenIme.Size = new System.Drawing.Size(114, 26);
            this.lblPrijavljenIme.TabIndex = 1;
            this.lblPrijavljenIme.Text = "Pero Perić";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picLogo.Image = global::VatrogasnoDrustvo.Properties.Resources.Vatrogasci1;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(428, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.pnlGlavna);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(997, 481);
            this.pnlGlavna.ResumeLayout(false);
            this.pnlGlavna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel pnlGlavna;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Label lblZvanje;
        private System.Windows.Forms.Label lblStaticZvanje;
        private System.Windows.Forms.Label lblPrijavljenIme;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
