namespace VatrogasnoDrustvo.Forme
{
    /**
     * Forma koja otvara skočni prozor sa tabličnim prikazom dobavljača.
     * Skok se desi pritiskom na gumb Dobavljači u formi Narudžbe.
     */
    partial class DobavljaciForma
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
            this.pnlDobavljaci = new VatrogasnoDrustvo.TablePanel();
            this.SuspendLayout();
            // 
            // pnlDobavljaci
            // 
            this.pnlDobavljaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDobavljaci.BackColor = System.Drawing.Color.Firebrick;
            this.pnlDobavljaci.Location = new System.Drawing.Point(-1, 0);
            this.pnlDobavljaci.Name = "pnlDobavljaci";
            this.pnlDobavljaci.Size = new System.Drawing.Size(985, 522);
            this.pnlDobavljaci.TabIndex = 0;
            // 
            // DobavljaciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 522);
            this.Controls.Add(this.pnlDobavljaci);
            this.Name = "DobavljaciForma";
            this.Text = "DobavljaciForme";
            this.ResumeLayout(false);

        }

        #endregion

        private TablePanel pnlDobavljaci;
    }
}