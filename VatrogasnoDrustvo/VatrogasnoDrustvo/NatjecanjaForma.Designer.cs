namespace VatrogasnoDrustvo
{
    partial class NatjecanjaForma
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
            this.btnNatjecanjePrijava = new System.Windows.Forms.Button();
            this.lblBaseNaslov.Text = "Natjecanja";
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Size = new System.Drawing.Size(105, 50);
            // 
            // btnNatjecanjePrijava
            // 
            this.btnNatjecanjePrijava.Location = new System.Drawing.Point(977, 630);
            this.btnNatjecanjePrijava.Name = "btnNatjecanjePrijava";
            this.btnNatjecanjePrijava.Size = new System.Drawing.Size(100, 50);
            this.btnNatjecanjePrijava.TabIndex = 7;
            this.btnNatjecanjePrijava.Text = "Prijavi se na natjecanje";
            this.btnNatjecanjePrijava.UseVisualStyleBackColor = true;
            // 
            // NatjecanjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnNatjecanjePrijava);
            this.Name = "NatjecanjaForma";
            this.Controls.SetChildIndex(this.btnNatjecanjePrijava, 0);
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.lblBaseSearch, 0);
            this.Controls.SetChildIndex(this.txtBaseSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnNatjecanjePrijava;

        #endregion
    }
}
