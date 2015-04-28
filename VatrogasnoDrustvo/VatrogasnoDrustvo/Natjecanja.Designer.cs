namespace VatrogasnoDrustvo
{
    partial class frmNatjecanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNatjecanja));
            this.tlstrpNatjecanja = new System.Windows.Forms.ToolStrip();
            this.tlstrplblNatjecanjaPocetna = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblNatjecanjaClanovi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblNatjecanjaIntervencije = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblNatjecanjaOprema = new System.Windows.Forms.ToolStripLabel();
            this.dgvNatjecanja = new System.Windows.Forms.DataGridView();
            this.lblNatjecanjaShow = new System.Windows.Forms.Label();
            this.numNatjecanjaShow = new System.Windows.Forms.NumericUpDown();
            this.lblNatjecanjaSearch = new System.Windows.Forms.Label();
            this.txtNatjecanjaSearch = new System.Windows.Forms.TextBox();
            this.btnNatjecanjaDodaj = new System.Windows.Forms.Button();
            this.btnNatjecanjePrijava = new System.Windows.Forms.Button();
            this.tlstrpNatjecanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNatjecanjaShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tlstrpNatjecanja
            // 
            this.tlstrpNatjecanja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplblNatjecanjaPocetna,
            this.toolStripSeparator1,
            this.tlstrplblNatjecanjaClanovi,
            this.toolStripSeparator2,
            this.tlstrplblNatjecanjaIntervencije,
            this.toolStripSeparator3,
            this.tlstrplblNatjecanjaOprema});
            this.tlstrpNatjecanja.Location = new System.Drawing.Point(0, 0);
            this.tlstrpNatjecanja.Name = "tlstrpNatjecanja";
            this.tlstrpNatjecanja.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tlstrpNatjecanja.Size = new System.Drawing.Size(1362, 33);
            this.tlstrpNatjecanja.TabIndex = 0;
            // 
            // tlstrplblNatjecanjaPocetna
            // 
            this.tlstrplblNatjecanjaPocetna.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblNatjecanjaPocetna.Name = "tlstrplblNatjecanjaPocetna";
            this.tlstrplblNatjecanjaPocetna.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblNatjecanjaPocetna.Text = "Početna";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblNatjecanjaClanovi
            // 
            this.tlstrplblNatjecanjaClanovi.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblNatjecanjaClanovi.Name = "tlstrplblNatjecanjaClanovi";
            this.tlstrplblNatjecanjaClanovi.Size = new System.Drawing.Size(47, 20);
            this.tlstrplblNatjecanjaClanovi.Text = "Članovi";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblNatjecanjaIntervencije
            // 
            this.tlstrplblNatjecanjaIntervencije.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblNatjecanjaIntervencije.Name = "tlstrplblNatjecanjaIntervencije";
            this.tlstrplblNatjecanjaIntervencije.Size = new System.Drawing.Size(68, 20);
            this.tlstrplblNatjecanjaIntervencije.Text = "Intervencije";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblNatjecanjaOprema
            // 
            this.tlstrplblNatjecanjaOprema.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblNatjecanjaOprema.Name = "tlstrplblNatjecanjaOprema";
            this.tlstrplblNatjecanjaOprema.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblNatjecanjaOprema.Text = "Oprema";
            // 
            // dgvNatjecanja
            // 
            this.dgvNatjecanja.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvNatjecanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNatjecanja.Location = new System.Drawing.Point(64, 132);
            this.dgvNatjecanja.Name = "dgvNatjecanja";
            this.dgvNatjecanja.Size = new System.Drawing.Size(1253, 473);
            this.dgvNatjecanja.TabIndex = 1;
            // 
            // lblNatjecanjaShow
            // 
            this.lblNatjecanjaShow.AutoSize = true;
            this.lblNatjecanjaShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatjecanjaShow.ForeColor = System.Drawing.Color.White;
            this.lblNatjecanjaShow.Location = new System.Drawing.Point(137, 98);
            this.lblNatjecanjaShow.Name = "lblNatjecanjaShow";
            this.lblNatjecanjaShow.Size = new System.Drawing.Size(51, 17);
            this.lblNatjecanjaShow.TabIndex = 2;
            this.lblNatjecanjaShow.Text = "Show:";
            // 
            // numNatjecanjaShow
            // 
            this.numNatjecanjaShow.Location = new System.Drawing.Point(212, 93);
            this.numNatjecanjaShow.Name = "numNatjecanjaShow";
            this.numNatjecanjaShow.Size = new System.Drawing.Size(48, 20);
            this.numNatjecanjaShow.TabIndex = 3;
            // 
            // lblNatjecanjaSearch
            // 
            this.lblNatjecanjaSearch.AutoSize = true;
            this.lblNatjecanjaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatjecanjaSearch.ForeColor = System.Drawing.Color.White;
            this.lblNatjecanjaSearch.Location = new System.Drawing.Point(932, 96);
            this.lblNatjecanjaSearch.Name = "lblNatjecanjaSearch";
            this.lblNatjecanjaSearch.Size = new System.Drawing.Size(64, 17);
            this.lblNatjecanjaSearch.TabIndex = 4;
            this.lblNatjecanjaSearch.Text = "Search:";
            // 
            // txtNatjecanjaSearch
            // 
            this.txtNatjecanjaSearch.Location = new System.Drawing.Point(1016, 95);
            this.txtNatjecanjaSearch.Name = "txtNatjecanjaSearch";
            this.txtNatjecanjaSearch.Size = new System.Drawing.Size(180, 20);
            this.txtNatjecanjaSearch.TabIndex = 5;
            // 
            // btnNatjecanjaDodaj
            // 
            this.btnNatjecanjaDodaj.Location = new System.Drawing.Point(1194, 630);
            this.btnNatjecanjaDodaj.Name = "btnNatjecanjaDodaj";
            this.btnNatjecanjaDodaj.Size = new System.Drawing.Size(123, 39);
            this.btnNatjecanjaDodaj.TabIndex = 6;
            this.btnNatjecanjaDodaj.Text = "Dodaj natjecanje";
            this.btnNatjecanjaDodaj.UseVisualStyleBackColor = true;
            // 
            // btnNatjecanjePrijava
            // 
            this.btnNatjecanjePrijava.Location = new System.Drawing.Point(980, 630);
            this.btnNatjecanjePrijava.Name = "btnNatjecanjePrijava";
            this.btnNatjecanjePrijava.Size = new System.Drawing.Size(121, 39);
            this.btnNatjecanjePrijava.TabIndex = 7;
            this.btnNatjecanjePrijava.Text = "Prijavi se na natjecanje";
            this.btnNatjecanjePrijava.UseVisualStyleBackColor = true;
            // 
            // frmNatjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnNatjecanjePrijava);
            this.Controls.Add(this.btnNatjecanjaDodaj);
            this.Controls.Add(this.txtNatjecanjaSearch);
            this.Controls.Add(this.lblNatjecanjaSearch);
            this.Controls.Add(this.numNatjecanjaShow);
            this.Controls.Add(this.lblNatjecanjaShow);
            this.Controls.Add(this.dgvNatjecanja);
            this.Controls.Add(this.tlstrpNatjecanja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNatjecanja";
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlstrpNatjecanja.ResumeLayout(false);
            this.tlstrpNatjecanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNatjecanjaShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlstrpNatjecanja;
        private System.Windows.Forms.ToolStripLabel tlstrplblNatjecanjaPocetna;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlstrplblNatjecanjaClanovi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlstrplblNatjecanjaIntervencije;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tlstrplblNatjecanjaOprema;
        private System.Windows.Forms.DataGridView dgvNatjecanja;
        private System.Windows.Forms.Label lblNatjecanjaShow;
        private System.Windows.Forms.NumericUpDown numNatjecanjaShow;
        private System.Windows.Forms.Label lblNatjecanjaSearch;
        private System.Windows.Forms.TextBox txtNatjecanjaSearch;
        private System.Windows.Forms.Button btnNatjecanjaDodaj;
        private System.Windows.Forms.Button btnNatjecanjePrijava;
    }
}