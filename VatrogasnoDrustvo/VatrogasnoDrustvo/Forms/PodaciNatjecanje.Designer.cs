namespace VatrogasnoDrustvo.InputForms
{
    /**
     * Forma za unos novog natjecanja.
     */
    partial class PodaciNatjecanje
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
            this.lblPodaciClanaNaslov = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.numKotizacija = new System.Windows.Forms.NumericUpDown();
            this.lblKotizacija = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.btnSalji = new System.Windows.Forms.Button();
            this.btnEkipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKotizacija)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPodaciClanaNaslov
            // 
            this.lblPodaciClanaNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPodaciClanaNaslov.AutoSize = true;
            this.lblPodaciClanaNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciClanaNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciClanaNaslov.Location = new System.Drawing.Point(67, 45);
            this.lblPodaciClanaNaslov.Name = "lblPodaciClanaNaslov";
            this.lblPodaciClanaNaslov.Size = new System.Drawing.Size(363, 37);
            this.lblPodaciClanaNaslov.TabIndex = 9;
            this.lblPodaciClanaNaslov.Text = "Unesite podatke o natjecanju";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(110, 123);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(220, 123);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(165, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // txtMjesto
            // 
            this.txtMjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMjesto.Location = new System.Drawing.Point(220, 164);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(165, 20);
            this.txtMjesto.TabIndex = 12;
            // 
            // lblMjesto
            // 
            this.lblMjesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjesto.ForeColor = System.Drawing.Color.White;
            this.lblMjesto.Location = new System.Drawing.Point(110, 164);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(60, 20);
            this.lblMjesto.TabIndex = 13;
            this.lblMjesto.Text = "Mjesto:";
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpVrijeme.Location = new System.Drawing.Point(220, 209);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(165, 20);
            this.dtpVrijeme.TabIndex = 14;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijeme.ForeColor = System.Drawing.Color.White;
            this.lblVrijeme.Location = new System.Drawing.Point(110, 209);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(66, 20);
            this.lblVrijeme.TabIndex = 15;
            this.lblVrijeme.Text = "Vrijeme:";
            // 
            // numKotizacija
            // 
            this.numKotizacija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numKotizacija.DecimalPlaces = 2;
            this.numKotizacija.Location = new System.Drawing.Point(220, 252);
            this.numKotizacija.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numKotizacija.Name = "numKotizacija";
            this.numKotizacija.Size = new System.Drawing.Size(165, 20);
            this.numKotizacija.TabIndex = 16;
            // 
            // lblKotizacija
            // 
            this.lblKotizacija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKotizacija.AutoSize = true;
            this.lblKotizacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKotizacija.ForeColor = System.Drawing.Color.White;
            this.lblKotizacija.Location = new System.Drawing.Point(110, 252);
            this.lblKotizacija.Name = "lblKotizacija";
            this.lblKotizacija.Size = new System.Drawing.Size(80, 20);
            this.lblKotizacija.TabIndex = 17;
            this.lblKotizacija.Text = "Kotizacija:";
            // 
            // lblTip
            // 
            this.lblTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.ForeColor = System.Drawing.Color.White;
            this.lblTip.Location = new System.Drawing.Point(110, 293);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(34, 20);
            this.lblTip.TabIndex = 18;
            this.lblTip.Text = "Tip:";
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(220, 293);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(165, 21);
            this.cmbTip.TabIndex = 19;
            // 
            // btnSalji
            // 
            this.btnSalji.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalji.Location = new System.Drawing.Point(220, 371);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(75, 26);
            this.btnSalji.TabIndex = 20;
            this.btnSalji.Text = "Šalji";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // btnEkipe
            // 
            this.btnEkipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkipe.Location = new System.Drawing.Point(220, 330);
            this.btnEkipe.Name = "btnEkipe";
            this.btnEkipe.Size = new System.Drawing.Size(75, 25);
            this.btnEkipe.TabIndex = 21;
            this.btnEkipe.Text = "Ekipe";
            this.btnEkipe.UseVisualStyleBackColor = true;
            this.btnEkipe.Click += new System.EventHandler(this.btnEkipe_Click);
            // 
            // PodaciNatjecanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(505, 409);
            this.Controls.Add(this.btnEkipe);
            this.Controls.Add(this.btnSalji);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblKotizacija);
            this.Controls.Add(this.numKotizacija);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.lblMjesto);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPodaciClanaNaslov);
            this.Name = "PodaciNatjecanje";
            this.Text = "PodaciNatjecanje";
            ((System.ComponentModel.ISupportInitialize)(this.numKotizacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPodaciClanaNaslov;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.NumericUpDown numKotizacija;
        private System.Windows.Forms.Label lblKotizacija;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Button btnSalji;
        private System.Windows.Forms.Button btnEkipe;
    }
}