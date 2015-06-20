namespace VatrogasnoDrustvo.Forms
{
    partial class PodaciNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodaciNarudzbe));
            this.btnSalji = new System.Windows.Forms.Button();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblRokIsporuke = new System.Windows.Forms.Label();
            this.dtpRokIsporuke = new System.Windows.Forms.DateTimePicker();
            this.txtNacinIsporuke = new System.Windows.Forms.TextBox();
            this.lblNacinIsporuke = new System.Windows.Forms.Label();
            this.lblPodaciNarudzbeNaslov = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalji
            // 
            this.btnSalji.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalji.Location = new System.Drawing.Point(905, 509);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(106, 27);
            this.btnSalji.TabIndex = 33;
            this.btnSalji.Text = "Kreiraj narudžbu";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(934, 274);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(165, 21);
            this.cmbDobavljac.TabIndex = 32;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobavljac.ForeColor = System.Drawing.Color.White;
            this.lblDobavljac.Location = new System.Drawing.Point(811, 275);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(82, 20);
            this.lblDobavljac.TabIndex = 31;
            this.lblDobavljac.Text = "Dobavljač:";
            // 
            // lblRokIsporuke
            // 
            this.lblRokIsporuke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRokIsporuke.AutoSize = true;
            this.lblRokIsporuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRokIsporuke.ForeColor = System.Drawing.Color.White;
            this.lblRokIsporuke.Location = new System.Drawing.Point(811, 196);
            this.lblRokIsporuke.Name = "lblRokIsporuke";
            this.lblRokIsporuke.Size = new System.Drawing.Size(106, 20);
            this.lblRokIsporuke.TabIndex = 28;
            this.lblRokIsporuke.Text = "Rok isporuke:";
            // 
            // dtpRokIsporuke
            // 
            this.dtpRokIsporuke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpRokIsporuke.Location = new System.Drawing.Point(934, 195);
            this.dtpRokIsporuke.Name = "dtpRokIsporuke";
            this.dtpRokIsporuke.Size = new System.Drawing.Size(165, 20);
            this.dtpRokIsporuke.TabIndex = 27;
            // 
            // txtNacinIsporuke
            // 
            this.txtNacinIsporuke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNacinIsporuke.Location = new System.Drawing.Point(934, 115);
            this.txtNacinIsporuke.Name = "txtNacinIsporuke";
            this.txtNacinIsporuke.Size = new System.Drawing.Size(165, 20);
            this.txtNacinIsporuke.TabIndex = 24;
            // 
            // lblNacinIsporuke
            // 
            this.lblNacinIsporuke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNacinIsporuke.AutoSize = true;
            this.lblNacinIsporuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNacinIsporuke.ForeColor = System.Drawing.Color.White;
            this.lblNacinIsporuke.Location = new System.Drawing.Point(811, 116);
            this.lblNacinIsporuke.Name = "lblNacinIsporuke";
            this.lblNacinIsporuke.Size = new System.Drawing.Size(117, 20);
            this.lblNacinIsporuke.TabIndex = 23;
            this.lblNacinIsporuke.Text = "Način isporuke:";
            // 
            // lblPodaciNarudzbeNaslov
            // 
            this.lblPodaciNarudzbeNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPodaciNarudzbeNaslov.AutoSize = true;
            this.lblPodaciNarudzbeNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciNarudzbeNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciNarudzbeNaslov.Location = new System.Drawing.Point(380, 35);
            this.lblPodaciNarudzbeNaslov.Name = "lblPodaciNarudzbeNaslov";
            this.lblPodaciNarudzbeNaslov.Size = new System.Drawing.Size(345, 37);
            this.lblPodaciNarudzbeNaslov.TabIndex = 22;
            this.lblPodaciNarudzbeNaslov.Text = "Unesite podatke o narudžbi";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(12, 90);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(793, 471);
            this.dgvStavke.TabIndex = 34;
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(905, 379);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(106, 26);
            this.btnDodajStavke.TabIndex = 35;
            this.btnDodajStavke.Text = "Dodaj stavke";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // PodaciNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1119, 573);
            this.Controls.Add(this.btnDodajStavke);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnSalji);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblRokIsporuke);
            this.Controls.Add(this.dtpRokIsporuke);
            this.Controls.Add(this.txtNacinIsporuke);
            this.Controls.Add(this.lblNacinIsporuke);
            this.Controls.Add(this.lblPodaciNarudzbeNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodaciNarudzbe";
            this.Text = "PodaciNarudzbe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalji;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblRokIsporuke;
        private System.Windows.Forms.DateTimePicker dtpRokIsporuke;
        private System.Windows.Forms.TextBox txtNacinIsporuke;
        private System.Windows.Forms.Label lblNacinIsporuke;
        private System.Windows.Forms.Label lblPodaciNarudzbeNaslov;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnDodajStavke;
    }
}