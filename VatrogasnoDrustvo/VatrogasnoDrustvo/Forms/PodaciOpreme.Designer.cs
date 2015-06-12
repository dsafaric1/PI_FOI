namespace VatrogasnoDrustvo.InputForms
{
    /**
     * Forma za unos nove opreme.
     */
    partial class PodaciOpreme
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblPodaciClanaNaslov = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblJacina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblGodiste = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.numGodiste = new System.Windows.Forms.NumericUpDown();
            this.numJacina = new System.Windows.Forms.NumericUpDown();
            this.numTezina = new System.Windows.Forms.NumericUpDown();
            this.lblTezina = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblFirstDeg = new System.Windows.Forms.Label();
            this.lblSecondDeg = new System.Windows.Forms.Label();
            this.btnSalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJacina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblVrsta
            // 
            this.lblVrsta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrsta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVrsta.Location = new System.Drawing.Point(62, 113);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(109, 20);
            this.lblVrsta.TabIndex = 1;
            this.lblVrsta.Text = "Vrsta opreme:";
            // 
            // lblPodaciClanaNaslov
            // 
            this.lblPodaciClanaNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPodaciClanaNaslov.AutoSize = true;
            this.lblPodaciClanaNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciClanaNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciClanaNaslov.Location = new System.Drawing.Point(59, 34);
            this.lblPodaciClanaNaslov.Name = "lblPodaciClanaNaslov";
            this.lblPodaciClanaNaslov.Size = new System.Drawing.Size(475, 37);
            this.lblPodaciClanaNaslov.TabIndex = 9;
            this.lblPodaciClanaNaslov.Text = "Izaberite vrstu iz liste i unesite podatke";
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(224, 321);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(193, 21);
            this.cmbTip.TabIndex = 29;
            this.cmbTip.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.ForeColor = System.Drawing.Color.White;
            this.lblTip.Location = new System.Drawing.Point(137, 322);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(34, 20);
            this.lblTip.TabIndex = 28;
            this.lblTip.Text = "Tip:";
            this.lblTip.Visible = false;
            // 
            // lblJacina
            // 
            this.lblJacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJacina.AutoSize = true;
            this.lblJacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJacina.ForeColor = System.Drawing.Color.White;
            this.lblJacina.Location = new System.Drawing.Point(112, 217);
            this.lblJacina.Name = "lblJacina";
            this.lblJacina.Size = new System.Drawing.Size(59, 20);
            this.lblJacina.TabIndex = 27;
            this.lblJacina.Text = "Jačina:";
            this.lblJacina.Visible = false;
            // 
            // numKolicina
            // 
            this.numKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numKolicina.Location = new System.Drawing.Point(224, 165);
            this.numKolicina.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(193, 20);
            this.numKolicina.TabIndex = 26;
            // 
            // lblGodiste
            // 
            this.lblGodiste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodiste.ForeColor = System.Drawing.Color.White;
            this.lblGodiste.Location = new System.Drawing.Point(105, 191);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(69, 20);
            this.lblGodiste.TabIndex = 25;
            this.lblGodiste.Text = "Godište:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.ForeColor = System.Drawing.Color.White;
            this.lblKolicina.Location = new System.Drawing.Point(104, 165);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(67, 20);
            this.lblKolicina.TabIndex = 23;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(224, 139);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(193, 20);
            this.txtNaziv.TabIndex = 21;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(120, 139);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv:";
            // 
            // numGodiste
            // 
            this.numGodiste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numGodiste.Location = new System.Drawing.Point(224, 191);
            this.numGodiste.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numGodiste.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numGodiste.Name = "numGodiste";
            this.numGodiste.Size = new System.Drawing.Size(193, 20);
            this.numGodiste.TabIndex = 30;
            this.numGodiste.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numJacina
            // 
            this.numJacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numJacina.Location = new System.Drawing.Point(224, 217);
            this.numJacina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numJacina.Name = "numJacina";
            this.numJacina.Size = new System.Drawing.Size(193, 20);
            this.numJacina.TabIndex = 32;
            this.numJacina.Visible = false;
            // 
            // numTezina
            // 
            this.numTezina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numTezina.Location = new System.Drawing.Point(224, 243);
            this.numTezina.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numTezina.Name = "numTezina";
            this.numTezina.Size = new System.Drawing.Size(193, 20);
            this.numTezina.TabIndex = 33;
            this.numTezina.Visible = false;
            // 
            // lblTezina
            // 
            this.lblTezina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTezina.AutoSize = true;
            this.lblTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTezina.ForeColor = System.Drawing.Color.White;
            this.lblTezina.Location = new System.Drawing.Point(111, 243);
            this.lblTezina.Name = "lblTezina";
            this.lblTezina.Size = new System.Drawing.Size(60, 20);
            this.lblTezina.TabIndex = 34;
            this.lblTezina.Text = "Težina:";
            this.lblTezina.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown1.Location = new System.Drawing.Point(224, 269);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown2.Location = new System.Drawing.Point(224, 295);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown2.TabIndex = 36;
            this.numericUpDown2.Visible = false;
            // 
            // lblFirstDeg
            // 
            this.lblFirstDeg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstDeg.AutoSize = true;
            this.lblFirstDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstDeg.ForeColor = System.Drawing.Color.White;
            this.lblFirstDeg.Location = new System.Drawing.Point(106, 269);
            this.lblFirstDeg.Name = "lblFirstDeg";
            this.lblFirstDeg.Size = new System.Drawing.Size(65, 20);
            this.lblFirstDeg.TabIndex = 37;
            this.lblFirstDeg.Text = "firstDeg";
            this.lblFirstDeg.Visible = false;
            // 
            // lblSecondDeg
            // 
            this.lblSecondDeg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecondDeg.AutoSize = true;
            this.lblSecondDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSecondDeg.ForeColor = System.Drawing.Color.White;
            this.lblSecondDeg.Location = new System.Drawing.Point(80, 295);
            this.lblSecondDeg.Name = "lblSecondDeg";
            this.lblSecondDeg.Size = new System.Drawing.Size(91, 20);
            this.lblSecondDeg.TabIndex = 38;
            this.lblSecondDeg.Text = "secondDeg";
            this.lblSecondDeg.Visible = false;
            // 
            // btnSalji
            // 
            this.btnSalji.Location = new System.Drawing.Point(224, 367);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(75, 23);
            this.btnSalji.TabIndex = 39;
            this.btnSalji.Text = "Pošalji";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // PodaciOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.btnSalji);
            this.Controls.Add(this.lblSecondDeg);
            this.Controls.Add(this.lblFirstDeg);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTezina);
            this.Controls.Add(this.numTezina);
            this.Controls.Add(this.numJacina);
            this.Controls.Add(this.numGodiste);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblJacina);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPodaciClanaNaslov);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.comboBox1);
            this.Name = "PodaciOpreme";
            this.Text = "PodaciOpreme";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJacina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblPodaciClanaNaslov;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblJacina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.NumericUpDown numGodiste;
        private System.Windows.Forms.NumericUpDown numJacina;
        private System.Windows.Forms.NumericUpDown numTezina;
        private System.Windows.Forms.Label lblTezina;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblFirstDeg;
        private System.Windows.Forms.Label lblSecondDeg;
        private System.Windows.Forms.Button btnSalji;
    }
}