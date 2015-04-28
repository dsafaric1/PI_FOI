namespace VatrogasnoDrustvo
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.lblPrijavljenIme = new System.Windows.Forms.Label();
            this.lblPrijavljenZvanje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picGlavnaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGlavnaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrijavljenIme
            // 
            this.lblPrijavljenIme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPrijavljenIme.AutoSize = true;
            this.lblPrijavljenIme.Location = new System.Drawing.Point(201, 523);
            this.lblPrijavljenIme.Name = "lblPrijavljenIme";
            this.lblPrijavljenIme.Size = new System.Drawing.Size(125, 13);
            this.lblPrijavljenIme.TabIndex = 2;
            this.lblPrijavljenIme.Text = "Prijavljen kao: Pero Peric";
            //this.lblPrijavljenIme.Click += new System.EventHandler(this.lblPrijavljenIme_Click);
            // 
            // lblPrijavljenZvanje
            // 
            this.lblPrijavljenZvanje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPrijavljenZvanje.AutoSize = true;
            this.lblPrijavljenZvanje.Location = new System.Drawing.Point(220, 545);
            this.lblPrijavljenZvanje.Name = "lblPrijavljenZvanje";
            this.lblPrijavljenZvanje.Size = new System.Drawing.Size(78, 13);
            this.lblPrijavljenZvanje.TabIndex = 3;
            this.lblPrijavljenZvanje.Text = "Zvanje: Casnik";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 99);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dobro došli!";
            // 
            // picGlavnaLogo
            // 
            this.picGlavnaLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picGlavnaLogo.Image = global::VatrogasnoDrustvo.Properties.Resources.Vatrogasci1;
            this.picGlavnaLogo.Location = new System.Drawing.Point(156, 108);
            this.picGlavnaLogo.Name = "picGlavnaLogo";
            this.picGlavnaLogo.Size = new System.Drawing.Size(225, 202);
            this.picGlavnaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGlavnaLogo.TabIndex = 1;
            this.picGlavnaLogo.TabStop = false;
            // 
            // frmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(553, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrijavljenZvanje);
            this.Controls.Add(this.lblPrijavljenIme);
            this.Controls.Add(this.picGlavnaLogo);
            this.Controls.Add(this.tlstrpGlavnaForma);
            this.Name = "frmGlavnaForma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlstrpGlavnaForma.ResumeLayout(false);
            this.tlstrpGlavnaForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGlavnaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.tlstrpGlavnaForma.Click += null;
        }

        #endregion

        private System.Windows.Forms.PictureBox picGlavnaLogo;
        private System.Windows.Forms.Label lblPrijavljenIme;
        private System.Windows.Forms.Label lblPrijavljenZvanje;
        private System.Windows.Forms.Label label1;
    }
}
