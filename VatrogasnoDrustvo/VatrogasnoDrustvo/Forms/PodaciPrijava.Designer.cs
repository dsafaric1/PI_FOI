namespace VatrogasnoDrustvo.InputForms
{
    /**
     * Forma za prijavu na natjecanje (unos).
     */
    partial class PodaciPrijava
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
            this.chckClanoviEkipe = new System.Windows.Forms.CheckedListBox();
            this.lblClanoviEkipe = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblUnesiteEkipu = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckClanoviEkipe
            // 
            this.chckClanoviEkipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chckClanoviEkipe.FormattingEnabled = true;
            this.chckClanoviEkipe.Location = new System.Drawing.Point(231, 246);
            this.chckClanoviEkipe.Name = "chckClanoviEkipe";
            this.chckClanoviEkipe.Size = new System.Drawing.Size(234, 94);
            this.chckClanoviEkipe.TabIndex = 20;
            // 
            // lblClanoviEkipe
            // 
            this.lblClanoviEkipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClanoviEkipe.AutoSize = true;
            this.lblClanoviEkipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanoviEkipe.ForeColor = System.Drawing.Color.White;
            this.lblClanoviEkipe.Location = new System.Drawing.Point(85, 246);
            this.lblClanoviEkipe.Name = "lblClanoviEkipe";
            this.lblClanoviEkipe.Size = new System.Drawing.Size(106, 20);
            this.lblClanoviEkipe.TabIndex = 19;
            this.lblClanoviEkipe.Text = "Članovi ekipe:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(231, 155);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(234, 20);
            this.txtNaziv.TabIndex = 21;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(85, 155);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(93, 20);
            this.lblNaziv.TabIndex = 22;
            this.lblNaziv.Text = "Naziv ekipe:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // lblKategorija
            // 
            this.lblKategorija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.Color.White;
            this.lblKategorija.Location = new System.Drawing.Point(85, 197);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(84, 20);
            this.lblKategorija.TabIndex = 24;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblUnesiteEkipu
            // 
            this.lblUnesiteEkipu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUnesiteEkipu.AutoSize = true;
            this.lblUnesiteEkipu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnesiteEkipu.ForeColor = System.Drawing.Color.White;
            this.lblUnesiteEkipu.Location = new System.Drawing.Point(123, 55);
            this.lblUnesiteEkipu.Name = "lblUnesiteEkipu";
            this.lblUnesiteEkipu.Size = new System.Drawing.Size(296, 31);
            this.lblUnesiteEkipu.TabIndex = 25;
            this.lblUnesiteEkipu.Text = "Unesite podatke o ekipi";
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrijavi.Location = new System.Drawing.Point(231, 414);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(75, 23);
            this.btnPrijavi.TabIndex = 26;
            this.btnPrijavi.Text = "Prijavi se";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // PodaciPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(535, 444);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.lblUnesiteEkipu);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.chckClanoviEkipe);
            this.Controls.Add(this.lblClanoviEkipe);
            this.Name = "PodaciPrijava";
            this.Text = "PodaciPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chckClanoviEkipe;
        private System.Windows.Forms.Label lblClanoviEkipe;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblUnesiteEkipu;
        private System.Windows.Forms.Button btnPrijavi;
    }
}