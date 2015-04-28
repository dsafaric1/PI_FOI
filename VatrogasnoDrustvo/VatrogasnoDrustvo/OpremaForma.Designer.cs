namespace VatrogasnoDrustvo
{
    partial class OpremaForma
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
            this.btnOpremaNarudzba = new System.Windows.Forms.Button();
            this.lblBaseNaslov.Text = "Oprema";
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Size = new System.Drawing.Size(105, 35);
            // 
            // btnOpremaNarudzba
            // 
            this.btnOpremaNarudzba.Location = new System.Drawing.Point(1005, 629);
            this.btnOpremaNarudzba.Name = "btnOpremaNarudzba";
            this.btnOpremaNarudzba.Size = new System.Drawing.Size(116, 35);
            this.btnOpremaNarudzba.TabIndex = 7;
            this.btnOpremaNarudzba.Text = "Ispiši narudžbe";
            this.btnOpremaNarudzba.UseVisualStyleBackColor = true;
            // 
            // OpremaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnOpremaNarudzba);
            this.Name = "OpremaForma";
            this.Controls.SetChildIndex(this.btnOpremaNarudzba, 0);
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.lblBaseSearch, 0);
            this.Controls.SetChildIndex(this.txtBaseSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpremaNarudzba;
    }
}
