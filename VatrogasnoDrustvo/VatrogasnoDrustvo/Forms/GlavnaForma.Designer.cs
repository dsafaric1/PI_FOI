namespace VatrogasnoDrustvo.Forme
{
    /**
     * Glavna forma koja se otvara nakon prijave. Ima na vrhu
     * ToolStrip objekt s poveznicama za promjenu prikaza panela.
     */
    partial class GlavnaForma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.tlstrplblPocetna = new System.Windows.Forms.ToolStripLabel();
            this.tlstrpsprtPrvi = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblIntervencije = new System.Windows.Forms.ToolStripLabel();
            this.tlstrpsprtDrugi = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblOprema = new System.Windows.Forms.ToolStripLabel();
            this.tlstrpsprtTreci = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblNatjecanja = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblClanovi = new System.Windows.Forms.ToolStripLabel();
            this.tlstrpGlavnaForma = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrpLabelRegistracija = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrplblIzvjestaji = new System.Windows.Forms.ToolStripLabel();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.lblIntervencije = new System.Windows.Forms.Label();
            this.lblPotrosnja = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.pnlGlavna = new VatrogasnoDrustvo.Controls.MainPanel();
            this.pnlTable = new VatrogasnoDrustvo.TablePanel();
            this.tlstrpGlavnaForma.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // tlstrplblPocetna
            // 
            this.tlstrplblPocetna.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlstrplblPocetna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlstrplblPocetna.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblPocetna.Name = "tlstrplblPocetna";
            this.tlstrplblPocetna.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblPocetna.Text = "Početna";
            this.tlstrplblPocetna.Click += new System.EventHandler(this.tlstrplblPocetna_Click);
            // 
            // tlstrpsprtPrvi
            // 
            this.tlstrpsprtPrvi.Name = "tlstrpsprtPrvi";
            this.tlstrpsprtPrvi.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblIntervencije
            // 
            this.tlstrplblIntervencije.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlstrplblIntervencije.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIntervencije.Name = "tlstrplblIntervencije";
            this.tlstrplblIntervencije.Size = new System.Drawing.Size(68, 20);
            this.tlstrplblIntervencije.Text = "Intervencije";
            this.tlstrplblIntervencije.Click += new System.EventHandler(this.tlstrplblIntervencije_Click);
            // 
            // tlstrpsprtDrugi
            // 
            this.tlstrpsprtDrugi.Name = "tlstrpsprtDrugi";
            this.tlstrpsprtDrugi.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblOprema
            // 
            this.tlstrplblOprema.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblOprema.Name = "tlstrplblOprema";
            this.tlstrplblOprema.Size = new System.Drawing.Size(50, 20);
            this.tlstrplblOprema.Text = "Oprema";
            this.tlstrplblOprema.Click += new System.EventHandler(this.tlstrplblOprema_Click);
            // 
            // tlstrpsprtTreci
            // 
            this.tlstrpsprtTreci.Name = "tlstrpsprtTreci";
            this.tlstrpsprtTreci.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblNatjecanja
            // 
            this.tlstrplblNatjecanja.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblNatjecanja.Name = "tlstrplblNatjecanja";
            this.tlstrplblNatjecanja.Size = new System.Drawing.Size(63, 20);
            this.tlstrplblNatjecanja.Text = "Natjecanja";
            this.tlstrplblNatjecanja.Click += new System.EventHandler(this.tlstrplblNatjecanja_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblClanovi
            // 
            this.tlstrplblClanovi.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblClanovi.Name = "tlstrplblClanovi";
            this.tlstrplblClanovi.Size = new System.Drawing.Size(47, 20);
            this.tlstrplblClanovi.Text = "Članovi";
            this.tlstrplblClanovi.Click += new System.EventHandler(this.tlstrplblClanovi_Click);
            // 
            // tlstrpGlavnaForma
            // 
            this.tlstrpGlavnaForma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplblPocetna,
            this.tlstrpsprtPrvi,
            this.tlstrplblIntervencije,
            this.tlstrpsprtDrugi,
            this.tlstrplblOprema,
            this.tlstrpsprtTreci,
            this.tlstrplblNatjecanja,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tlstrplblClanovi,
            this.toolStripSeparator2,
            this.tlstrpLabelRegistracija,
            this.toolStripSeparator3,
            this.tlstrplblIzvjestaji});
            this.tlstrpGlavnaForma.Location = new System.Drawing.Point(0, 0);
            this.tlstrpGlavnaForma.Name = "tlstrpGlavnaForma";
            this.tlstrpGlavnaForma.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.tlstrpGlavnaForma.Size = new System.Drawing.Size(997, 33);
            this.tlstrpGlavnaForma.TabIndex = 0;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrpLabelRegistracija
            // 
            this.tlstrpLabelRegistracija.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrpLabelRegistracija.Name = "tlstrpLabelRegistracija";
            this.tlstrpLabelRegistracija.Size = new System.Drawing.Size(67, 20);
            this.tlstrpLabelRegistracija.Text = "Registracija";
            this.tlstrpLabelRegistracija.Click += new System.EventHandler(this.tlstrpLabelRegistracija_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tlstrplblIzvjestaji
            // 
            this.tlstrplblIzvjestaji.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.tlstrplblIzvjestaji.Name = "tlstrplblIzvjestaji";
            this.tlstrplblIzvjestaji.Size = new System.Drawing.Size(51, 20);
            this.tlstrplblIzvjestaji.Text = "Izvještaji";
            this.tlstrplblIzvjestaji.Click += new System.EventHandler(this.tlstrplblIzvjestaji_Click);
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatistics.Controls.Add(this.label2);
            this.pnlStatistics.Controls.Add(this.label1);
            this.pnlStatistics.Controls.Add(this.label3);
            this.pnlStatistics.Controls.Add(this.panel1);
            this.pnlStatistics.Controls.Add(this.lblRezultati);
            this.pnlStatistics.Controls.Add(this.lblIntervencije);
            this.pnlStatistics.Controls.Add(this.lblPotrosnja);
            this.pnlStatistics.Controls.Add(this.lblOcjena);
            this.pnlStatistics.Location = new System.Drawing.Point(0, 36);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(997, 441);
            this.pnlStatistics.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "_____________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "_____________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "_____________________________________";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.chart);
            this.panel1.Controls.Add(this.dgvStatistics);
            this.panel1.Location = new System.Drawing.Point(280, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 419);
            this.panel1.TabIndex = 12;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.Firebrick;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 3;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 3;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Firebrick;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Firebrick;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.SystemColors.ControlDark;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(156, 8);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Podaci";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(404, 237);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dgvStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatistics.Location = new System.Drawing.Point(156, 246);
            this.dgvStatistics.Name = "dgvStatistics";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatistics.Size = new System.Drawing.Size(404, 165);
            this.dgvStatistics.TabIndex = 1;
            // 
            // lblRezultati
            // 
            this.lblRezultati.AutoSize = true;
            this.lblRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultati.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRezultati.Location = new System.Drawing.Point(25, 130);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(162, 20);
            this.lblRezultati.TabIndex = 11;
            this.lblRezultati.Text = "Rezultati vatrogasca";
            this.lblRezultati.Click += new System.EventHandler(this.lblRezultati_Click);
            // 
            // lblIntervencije
            // 
            this.lblIntervencije.AutoSize = true;
            this.lblIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervencije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntervencije.Location = new System.Drawing.Point(59, 205);
            this.lblIntervencije.Name = "lblIntervencije";
            this.lblIntervencije.Size = new System.Drawing.Size(94, 20);
            this.lblIntervencije.TabIndex = 10;
            this.lblIntervencije.Text = "Intervencije";
            this.lblIntervencije.Click += new System.EventHandler(this.lblIntervencije_Click);
            // 
            // lblPotrosnja
            // 
            this.lblPotrosnja.AutoSize = true;
            this.lblPotrosnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPotrosnja.Location = new System.Drawing.Point(32, 282);
            this.lblPotrosnja.Name = "lblPotrosnja";
            this.lblPotrosnja.Size = new System.Drawing.Size(155, 20);
            this.lblPotrosnja.TabIndex = 9;
            this.lblPotrosnja.Text = "Mjesečna potrošnja";
            this.lblPotrosnja.Click += new System.EventHandler(this.lblPotrosnja_Click);
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOcjena.Location = new System.Drawing.Point(6, 48);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(225, 20);
            this.lblOcjena.TabIndex = 8;
            this.lblOcjena.Text = "Prosječna ocjena vatrogasca";
            this.lblOcjena.Click += new System.EventHandler(this.lblOcjena_Click);
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGlavna.BackColor = System.Drawing.Color.Firebrick;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 36);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(997, 441);
            this.pnlGlavna.TabIndex = 1;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTable.Location = new System.Drawing.Point(0, 36);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(997, 441);
            this.pnlTable.TabIndex = 3;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(997, 481);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.tlstrpGlavnaForma);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.pnlTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlstrpGlavnaForma.ResumeLayout(false);
            this.tlstrpGlavnaForma.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        protected System.Windows.Forms.ToolStripLabel tlstrplblPocetna;
        protected System.Windows.Forms.ToolStripSeparator tlstrpsprtPrvi;
        protected System.Windows.Forms.ToolStripLabel tlstrplblIntervencije;
        protected System.Windows.Forms.ToolStripSeparator tlstrpsprtDrugi;
        protected System.Windows.Forms.ToolStripLabel tlstrplblOprema;
        protected System.Windows.Forms.ToolStripSeparator tlstrpsprtTreci;
        protected System.Windows.Forms.ToolStripLabel tlstrplblNatjecanja;
        protected System.Windows.Forms.ToolStripLabel toolStripLabel1;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripLabel tlstrplblClanovi;
        protected System.Windows.Forms.ToolStrip tlstrpGlavnaForma;
        private Controls.MainPanel pnlGlavna;
        private TablePanel pnlTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlstrpLabelRegistracija;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tlstrplblIzvjestaji;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.Label lblIntervencije;
        private System.Windows.Forms.Label lblPotrosnja;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}