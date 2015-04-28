namespace VatrogasnoDrustvo
{
    partial class frmOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOprema));
            this.tlstrpOprema = new System.Windows.Forms.ToolStrip();
            this.tlstrplblOpremaPocetna = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblOpremaClanovi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblOpremaINtervencije = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblOpremaNatjecanja = new System.Windows.Forms.ToolStripLabel();
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.lblOpremaSearch = new System.Windows.Forms.Label();
            this.txtOpremaSsearch = new System.Windows.Forms.TextBox();
            this.btnOpremaDodaj = new System.Windows.Forms.Button();
            this.btnOpremaNarudzba = new System.Windows.Forms.Button();
            this.tlstrpOprema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // tlstrpOprema
            // 
            this.tlstrpOprema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplblOpremaPocetna,
            this.toolStripSeparator1,
            this.tlstrplblOpremaClanovi,
            this.toolStripSeparator2,
            this.tlstrplblOpremaINtervencije,
            this.toolStripSeparator3,
            this.tlstrplblOpremaNatjecanja});
            this.tlstrpOprema.Location = new System.Drawing.Point(0, 0);
            this.tlstrpOprema.Name = "tlstrpOprema";
            this.tlstrpOprema.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tlstrpOprema.Size = new System.Drawing.Size(1362, 33);
            this.tlstrpOprema.TabIndex = 0;
            // 
            // tlstrplblOpremaPocetna
            // 
            this.tlstrplblOpremaPocetna.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblOpremaPocetna.Name = "tlstrplblOpremaPocetna";
            this.tlstrplblOpremaPocetna.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblOpremaPocetna.Text = "Početna";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblOpremaClanovi
            // 
            this.tlstrplblOpremaClanovi.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblOpremaClanovi.Name = "tlstrplblOpremaClanovi";
            this.tlstrplblOpremaClanovi.Size = new System.Drawing.Size(47, 20);
            this.tlstrplblOpremaClanovi.Text = "Članovi";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblOpremaINtervencije
            // 
            this.tlstrplblOpremaINtervencije.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblOpremaINtervencije.Name = "tlstrplblOpremaINtervencije";
            this.tlstrplblOpremaINtervencije.Size = new System.Drawing.Size(68, 20);
            this.tlstrplblOpremaINtervencije.Text = "Intervencije";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblOpremaNatjecanja
            // 
            this.tlstrplblOpremaNatjecanja.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblOpremaNatjecanja.Name = "tlstrplblOpremaNatjecanja";
            this.tlstrplblOpremaNatjecanja.Size = new System.Drawing.Size(63, 20);
            this.tlstrplblOpremaNatjecanja.Text = "Natjecanja";
            // 
            // dgvOprema
            // 
            this.dgvOprema.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(64, 132);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.Size = new System.Drawing.Size(1253, 473);
            this.dgvOprema.TabIndex = 1;
            // 
            // lblOpremaSearch
            // 
            this.lblOpremaSearch.AutoSize = true;
            this.lblOpremaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpremaSearch.ForeColor = System.Drawing.Color.White;
            this.lblOpremaSearch.Location = new System.Drawing.Point(932, 96);
            this.lblOpremaSearch.Name = "lblOpremaSearch";
            this.lblOpremaSearch.Size = new System.Drawing.Size(64, 17);
            this.lblOpremaSearch.TabIndex = 4;
            this.lblOpremaSearch.Text = "Search:";
            // 
            // txtOpremaSsearch
            // 
            this.txtOpremaSsearch.Location = new System.Drawing.Point(1016, 95);
            this.txtOpremaSsearch.Name = "txtOpremaSsearch";
            this.txtOpremaSsearch.Size = new System.Drawing.Size(180, 20);
            this.txtOpremaSsearch.TabIndex = 5;
            // 
            // btnOpremaDodaj
            // 
            this.btnOpremaDodaj.Location = new System.Drawing.Point(1207, 629);
            this.btnOpremaDodaj.Name = "btnOpremaDodaj";
            this.btnOpremaDodaj.Size = new System.Drawing.Size(110, 35);
            this.btnOpremaDodaj.TabIndex = 6;
            this.btnOpremaDodaj.Text = "Dodaj opremu";
            this.btnOpremaDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOpremaNarudzba
            // 
            this.btnOpremaNarudzba.Location = new System.Drawing.Point(1005, 629);
            this.btnOpremaNarudzba.Name = "btnOpremaNarudzba";
            this.btnOpremaNarudzba.Size = new System.Drawing.Size(116, 35);
            this.btnOpremaNarudzba.TabIndex = 7;
            this.btnOpremaNarudzba.Text = "Ispiši narudžbe";
            this.btnOpremaNarudzba.UseVisualStyleBackColor = true;
            // 
            // frmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnOpremaNarudzba);
            this.Controls.Add(this.btnOpremaDodaj);
            this.Controls.Add(this.txtOpremaSsearch);
            this.Controls.Add(this.lblOpremaSearch);
            this.Controls.Add(this.dgvOprema);
            this.Controls.Add(this.tlstrpOprema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOprema";
            this.Text = "Oprema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlstrpOprema.ResumeLayout(false);
            this.tlstrpOprema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlstrpOprema;
        private System.Windows.Forms.ToolStripLabel tlstrplblOpremaPocetna;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlstrplblOpremaClanovi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlstrplblOpremaINtervencije;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tlstrplblOpremaNatjecanja;
        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Label lblOpremaSearch;
        private System.Windows.Forms.TextBox txtOpremaSsearch;
        private System.Windows.Forms.Button btnOpremaDodaj;
        private System.Windows.Forms.Button btnOpremaNarudzba;
    }
}