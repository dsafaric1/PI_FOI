namespace VatrogasnoDrustvo.Forms
{
    partial class GraphPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblPotrosnja = new System.Windows.Forms.Label();
            this.lblIntervencije = new System.Windows.Forms.Label();
            this.lblRezultati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.Black;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineWidth = 3;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineWidth = 3;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(144, 17);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(485, 206);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.chart);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(254, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 426);
            this.panel1.TabIndex = 2;
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOcjena.Location = new System.Drawing.Point(10, 48);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(227, 22);
            this.lblOcjena.TabIndex = 3;
            this.lblOcjena.Text = "Prosječna ocjena vatrogasca";
            this.lblOcjena.Click += new System.EventHandler(this.lblOcjena_Click);
            // 
            // lblPotrosnja
            // 
            this.lblPotrosnja.AutoSize = true;
            this.lblPotrosnja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPotrosnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPotrosnja.Location = new System.Drawing.Point(10, 158);
            this.lblPotrosnja.Name = "lblPotrosnja";
            this.lblPotrosnja.Size = new System.Drawing.Size(157, 22);
            this.lblPotrosnja.TabIndex = 4;
            this.lblPotrosnja.Text = "Mjesečna potrošnja";
            this.lblPotrosnja.Click += new System.EventHandler(this.lblPotrosnja_Click);
            // 
            // lblIntervencije
            // 
            this.lblIntervencije.AutoSize = true;
            this.lblIntervencije.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervencije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIntervencije.Location = new System.Drawing.Point(10, 120);
            this.lblIntervencije.Name = "lblIntervencije";
            this.lblIntervencije.Size = new System.Drawing.Size(96, 22);
            this.lblIntervencije.TabIndex = 5;
            this.lblIntervencije.Text = "Intervencije";
            this.lblIntervencije.Click += new System.EventHandler(this.lblIntervencije_Click);
            // 
            // lblRezultati
            // 
            this.lblRezultati.AutoSize = true;
            this.lblRezultati.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultati.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRezultati.Location = new System.Drawing.Point(10, 83);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(164, 22);
            this.lblRezultati.TabIndex = 6;
            this.lblRezultati.Text = "Rezultati vatrogasca";
            this.lblRezultati.Click += new System.EventHandler(this.lblRezultati_Click);
            // 
            // GraphPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.lblIntervencije);
            this.Controls.Add(this.lblPotrosnja);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.panel1);
            this.Name = "GraphPanel";
            this.Size = new System.Drawing.Size(1014, 454);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblPotrosnja;
        private System.Windows.Forms.Label lblIntervencije;
        private System.Windows.Forms.Label lblRezultati;
    }
}
