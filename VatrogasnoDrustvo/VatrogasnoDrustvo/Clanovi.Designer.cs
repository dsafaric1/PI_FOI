namespace VatrogasnoDrustvo
{
    partial class frmClanovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClanovi));
            this.tlstrpClanovi = new System.Windows.Forms.ToolStrip();
            this.tlstrplblClanoviPocetna = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblClanoviIntervencije = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblClanoviOprema = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblClanoviNatjecanja = new System.Windows.Forms.ToolStripLabel();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.txtClanoviSearch = new System.Windows.Forms.TextBox();
            this.lblClanoviSearch = new System.Windows.Forms.Label();
            this.lblClanoviShow = new System.Windows.Forms.Label();
            this.numClanoviShow = new System.Windows.Forms.NumericUpDown();
            this.btnClanoviDodaj = new System.Windows.Forms.Button();
            this.tlstrpClanovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClanoviShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tlstrpClanovi
            // 
            this.tlstrpClanovi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplblClanoviPocetna,
            this.toolStripSeparator1,
            this.tlstrplblClanoviIntervencije,
            this.toolStripSeparator2,
            this.tlstrplblClanoviOprema,
            this.toolStripSeparator3,
            this.tlstrplblClanoviNatjecanja});
            this.tlstrpClanovi.Location = new System.Drawing.Point(0, 0);
            this.tlstrpClanovi.Name = "tlstrpClanovi";
            this.tlstrpClanovi.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tlstrpClanovi.Size = new System.Drawing.Size(1362, 33);
            this.tlstrpClanovi.TabIndex = 0;
            // 
            // tlstrplblClanoviPocetna
            // 
            this.tlstrplblClanoviPocetna.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlstrplblClanoviPocetna.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblClanoviPocetna.Name = "tlstrplblClanoviPocetna";
            this.tlstrplblClanoviPocetna.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblClanoviPocetna.Text = "Početna";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblClanoviIntervencije
            // 
            this.tlstrplblClanoviIntervencije.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblClanoviIntervencije.Name = "tlstrplblClanoviIntervencije";
            this.tlstrplblClanoviIntervencije.Size = new System.Drawing.Size(68, 20);
            this.tlstrplblClanoviIntervencije.Text = "Intervencije";
            this.tlstrplblClanoviIntervencije.Click += new System.EventHandler(this.tlstrplblClanoviIntervencije_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblClanoviOprema
            // 
            this.tlstrplblClanoviOprema.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblClanoviOprema.Name = "tlstrplblClanoviOprema";
            this.tlstrplblClanoviOprema.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblClanoviOprema.Text = "Oprema";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblClanoviNatjecanja
            // 
            this.tlstrplblClanoviNatjecanja.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblClanoviNatjecanja.Name = "tlstrplblClanoviNatjecanja";
            this.tlstrplblClanoviNatjecanja.Size = new System.Drawing.Size(63, 20);
            this.tlstrplblClanoviNatjecanja.Text = "Natjecanja";
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanovi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClanovi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(64, 132);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.Size = new System.Drawing.Size(1253, 473);
            this.dgvClanovi.TabIndex = 1;
            // 
            // txtClanoviSearch
            // 
            this.txtClanoviSearch.Location = new System.Drawing.Point(1016, 95);
            this.txtClanoviSearch.Name = "txtClanoviSearch";
            this.txtClanoviSearch.Size = new System.Drawing.Size(147, 20);
            this.txtClanoviSearch.TabIndex = 2;
            // 
            // lblClanoviSearch
            // 
            this.lblClanoviSearch.AutoSize = true;
            this.lblClanoviSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanoviSearch.ForeColor = System.Drawing.Color.White;
            this.lblClanoviSearch.Location = new System.Drawing.Point(932, 96);
            this.lblClanoviSearch.Name = "lblClanoviSearch";
            this.lblClanoviSearch.Size = new System.Drawing.Size(64, 17);
            this.lblClanoviSearch.TabIndex = 3;
            this.lblClanoviSearch.Text = "Search:";
            // 
            // lblClanoviShow
            // 
            this.lblClanoviShow.AutoSize = true;
            this.lblClanoviShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanoviShow.ForeColor = System.Drawing.Color.White;
            this.lblClanoviShow.Location = new System.Drawing.Point(137, 98);
            this.lblClanoviShow.Name = "lblClanoviShow";
            this.lblClanoviShow.Size = new System.Drawing.Size(51, 17);
            this.lblClanoviShow.TabIndex = 4;
            this.lblClanoviShow.Text = "Show:";
            this.lblClanoviShow.Click += new System.EventHandler(this.lblClanoviShow_Click);
            // 
            // numClanoviShow
            // 
            this.numClanoviShow.Location = new System.Drawing.Point(212, 93);
            this.numClanoviShow.Name = "numClanoviShow";
            this.numClanoviShow.Size = new System.Drawing.Size(48, 20);
            this.numClanoviShow.TabIndex = 5;
            // 
            // btnClanoviDodaj
            // 
            this.btnClanoviDodaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClanoviDodaj.Location = new System.Drawing.Point(1212, 628);
            this.btnClanoviDodaj.Name = "btnClanoviDodaj";
            this.btnClanoviDodaj.Size = new System.Drawing.Size(105, 31);
            this.btnClanoviDodaj.TabIndex = 6;
            this.btnClanoviDodaj.Text = "Dodaj člana";
            this.btnClanoviDodaj.UseVisualStyleBackColor = true;
            // 
            // frmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnClanoviDodaj);
            this.Controls.Add(this.numClanoviShow);
            this.Controls.Add(this.lblClanoviShow);
            this.Controls.Add(this.lblClanoviSearch);
            this.Controls.Add(this.txtClanoviSearch);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.tlstrpClanovi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClanovi";
            this.Text = "Članovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlstrpClanovi.ResumeLayout(false);
            this.tlstrpClanovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClanoviShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlstrpClanovi;
        private System.Windows.Forms.ToolStripLabel tlstrplblClanoviPocetna;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlstrplblClanoviIntervencije;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlstrplblClanoviOprema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tlstrplblClanoviNatjecanja;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.TextBox txtClanoviSearch;
        private System.Windows.Forms.Label lblClanoviSearch;
        private System.Windows.Forms.Label lblClanoviShow;
        private System.Windows.Forms.NumericUpDown numClanoviShow;
        private System.Windows.Forms.Button btnClanoviDodaj;
    }
}