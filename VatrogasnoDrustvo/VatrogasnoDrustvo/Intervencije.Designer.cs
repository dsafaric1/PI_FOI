namespace VatrogasnoDrustvo
{
    partial class frmIntervencije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntervencije));
            this.dgvIntervencije = new System.Windows.Forms.DataGridView();
            this.tlstrpIntervencije = new System.Windows.Forms.ToolStrip();
            this.tlstrplblIntervencijePocetna = new System.Windows.Forms.ToolStripLabel();
            this.Članovi = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblIntervencijeClanovi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblIntervencijeOprema = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblIntervencijeNatjecanja = new System.Windows.Forms.ToolStripLabel();
            this.btnIntervencijeDodaj = new System.Windows.Forms.Button();
            this.txtIntervencijeSearch = new System.Windows.Forms.TextBox();
            this.lblIntervencijeSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervencije)).BeginInit();
            this.tlstrpIntervencije.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntervencije
            // 
            this.dgvIntervencije.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvIntervencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervencije.Location = new System.Drawing.Point(64, 132);
            this.dgvIntervencije.Name = "dgvIntervencije";
            this.dgvIntervencije.Size = new System.Drawing.Size(1253, 473);
            this.dgvIntervencije.TabIndex = 0;
            // 
            // tlstrpIntervencije
            // 
            this.tlstrpIntervencije.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplblIntervencijePocetna,
            this.Članovi,
            this.tlstrplblIntervencijeClanovi,
            this.toolStripSeparator1,
            this.tlstrplblIntervencijeOprema,
            this.toolStripSeparator2,
            this.tlstrplblIntervencijeNatjecanja});
            this.tlstrpIntervencije.Location = new System.Drawing.Point(0, 0);
            this.tlstrpIntervencije.Name = "tlstrpIntervencije";
            this.tlstrpIntervencije.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tlstrpIntervencije.Size = new System.Drawing.Size(1362, 33);
            this.tlstrpIntervencije.TabIndex = 1;
            // 
            // tlstrplblIntervencijePocetna
            // 
            this.tlstrplblIntervencijePocetna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlstrplblIntervencijePocetna.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIntervencijePocetna.Name = "tlstrplblIntervencijePocetna";
            this.tlstrplblIntervencijePocetna.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblIntervencijePocetna.Text = "Početna";
            // 
            // Članovi
            // 
            this.Članovi.Name = "Članovi";
            this.Članovi.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblIntervencijeClanovi
            // 
            this.tlstrplblIntervencijeClanovi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlstrplblIntervencijeClanovi.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIntervencijeClanovi.Name = "tlstrplblIntervencijeClanovi";
            this.tlstrplblIntervencijeClanovi.Size = new System.Drawing.Size(47, 20);
            this.tlstrplblIntervencijeClanovi.Text = "Članovi";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblIntervencijeOprema
            // 
            this.tlstrplblIntervencijeOprema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlstrplblIntervencijeOprema.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIntervencijeOprema.Name = "tlstrplblIntervencijeOprema";
            this.tlstrplblIntervencijeOprema.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblIntervencijeOprema.Text = "Oprema";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblIntervencijeNatjecanja
            // 
            this.tlstrplblIntervencijeNatjecanja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlstrplblIntervencijeNatjecanja.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIntervencijeNatjecanja.Name = "tlstrplblIntervencijeNatjecanja";
            this.tlstrplblIntervencijeNatjecanja.Size = new System.Drawing.Size(63, 20);
            this.tlstrplblIntervencijeNatjecanja.Text = "Natjecanja";
            // 
            // btnIntervencijeDodaj
            // 
            this.btnIntervencijeDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnIntervencijeDodaj.Location = new System.Drawing.Point(1193, 629);
            this.btnIntervencijeDodaj.Name = "btnIntervencijeDodaj";
            this.btnIntervencijeDodaj.Size = new System.Drawing.Size(124, 34);
            this.btnIntervencijeDodaj.TabIndex = 2;
            this.btnIntervencijeDodaj.Text = "Dodaj intervenciju";
            this.btnIntervencijeDodaj.UseVisualStyleBackColor = true;
            // 
            // txtIntervencijeSearch
            // 
            this.txtIntervencijeSearch.Location = new System.Drawing.Point(1016, 95);
            this.txtIntervencijeSearch.Name = "txtIntervencijeSearch";
            this.txtIntervencijeSearch.Size = new System.Drawing.Size(180, 20);
            this.txtIntervencijeSearch.TabIndex = 3;
            // 
            // lblIntervencijeSearch
            // 
            this.lblIntervencijeSearch.AutoSize = true;
            this.lblIntervencijeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervencijeSearch.ForeColor = System.Drawing.Color.White;
            this.lblIntervencijeSearch.Location = new System.Drawing.Point(932, 96);
            this.lblIntervencijeSearch.Name = "lblIntervencijeSearch";
            this.lblIntervencijeSearch.Size = new System.Drawing.Size(64, 17);
            this.lblIntervencijeSearch.TabIndex = 4;
            this.lblIntervencijeSearch.Text = "Search:";
            // 
            // frmIntervencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.lblIntervencijeSearch);
            this.Controls.Add(this.txtIntervencijeSearch);
            this.Controls.Add(this.btnIntervencijeDodaj);
            this.Controls.Add(this.tlstrpIntervencije);
            this.Controls.Add(this.dgvIntervencije);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntervencije";
            this.Text = "Intervencije";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervencije)).EndInit();
            this.tlstrpIntervencije.ResumeLayout(false);
            this.tlstrpIntervencije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntervencije;
        private System.Windows.Forms.ToolStrip tlstrpIntervencije;
        private System.Windows.Forms.ToolStripLabel tlstrplblIntervencijePocetna;
        private System.Windows.Forms.ToolStripSeparator Članovi;
        private System.Windows.Forms.ToolStripLabel tlstrplblIntervencijeClanovi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlstrplblIntervencijeOprema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlstrplblIntervencijeNatjecanja;
        private System.Windows.Forms.Button btnIntervencijeDodaj;
        private System.Windows.Forms.TextBox txtIntervencijeSearch;
        private System.Windows.Forms.Label lblIntervencijeSearch;
    }
}