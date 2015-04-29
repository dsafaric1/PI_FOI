namespace VatrogasnoDrustvo
{
    partial class IntervencijeForma
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
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBaseNaslov
            // 
            this.lblBaseNaslov.Size = new System.Drawing.Size(271, 49);
            this.lblBaseNaslov.Text = "Intervencije";
            // 
            // IntervencijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Name = "IntervencijeForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
