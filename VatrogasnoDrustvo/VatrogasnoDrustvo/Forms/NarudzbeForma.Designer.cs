namespace VatrogasnoDrustvo.Forme
{
    /**
     * Tablični prikaz narudžbi van glavne forme. 
     * Skočni prozor na klik gumba Prikaži narudžbe u panelu Oprema.
     */
    partial class NarudzbeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NarudzbeForma));
            this.pnlNarudzbe = new VatrogasnoDrustvo.TablePanel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlNarudzbe
            // 
            this.pnlNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNarudzbe.BackColor = System.Drawing.Color.Firebrick;
            this.pnlNarudzbe.Location = new System.Drawing.Point(0, 1);
            this.pnlNarudzbe.Name = "pnlNarudzbe";
            this.pnlNarudzbe.Size = new System.Drawing.Size(1021, 505);
            this.pnlNarudzbe.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(730, 463);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(138, 30);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Generiraj PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // NarudzbeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 505);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.pnlNarudzbe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NarudzbeForma";
            this.Text = "NarudzbeForma";
            this.ResumeLayout(false);

        }

        #endregion

        private TablePanel pnlNarudzbe;
        private System.Windows.Forms.Button btnPDF;
    }
}