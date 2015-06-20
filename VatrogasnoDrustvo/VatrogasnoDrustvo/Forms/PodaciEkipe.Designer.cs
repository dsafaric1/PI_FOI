namespace VatrogasnoDrustvo.Forms
{
    partial class PodaciEkipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodaciEkipe));
            this.btnSalji = new System.Windows.Forms.Button();
            this.lblKotizacija = new System.Windows.Forms.Label();
            this.numRezultat = new System.Windows.Forms.NumericUpDown();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPodaciClanaNaslov = new System.Windows.Forms.Label();
            this.numOcjena = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numRezultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalji
            // 
            this.btnSalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalji.Location = new System.Drawing.Point(739, 459);
            this.btnSalji.Name = "btnSalji";
            this.btnSalji.Size = new System.Drawing.Size(75, 26);
            this.btnSalji.TabIndex = 33;
            this.btnSalji.Text = "Pošalji";
            this.btnSalji.UseVisualStyleBackColor = true;
            this.btnSalji.Click += new System.EventHandler(this.btnSalji_Click);
            // 
            // lblKotizacija
            // 
            this.lblKotizacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKotizacija.AutoSize = true;
            this.lblKotizacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKotizacija.ForeColor = System.Drawing.Color.White;
            this.lblKotizacija.Location = new System.Drawing.Point(265, 63);
            this.lblKotizacija.Name = "lblKotizacija";
            this.lblKotizacija.Size = new System.Drawing.Size(73, 20);
            this.lblKotizacija.TabIndex = 30;
            this.lblKotizacija.Text = "Rezultat:";
            // 
            // numRezultat
            // 
            this.numRezultat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRezultat.Location = new System.Drawing.Point(344, 63);
            this.numRezultat.Name = "numRezultat";
            this.numRezultat.Size = new System.Drawing.Size(48, 20);
            this.numRezultat.TabIndex = 29;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(69, 63);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(165, 20);
            this.txtNaziv.TabIndex = 24;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(12, 63);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 23;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblPodaciClanaNaslov
            // 
            this.lblPodaciClanaNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPodaciClanaNaslov.AutoSize = true;
            this.lblPodaciClanaNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciClanaNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciClanaNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblPodaciClanaNaslov.Name = "lblPodaciClanaNaslov";
            this.lblPodaciClanaNaslov.Size = new System.Drawing.Size(168, 37);
            this.lblPodaciClanaNaslov.TabIndex = 22;
            this.lblPodaciClanaNaslov.Text = "Podaci ekipe";
            // 
            // numOcjena
            // 
            this.numOcjena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOcjena.Location = new System.Drawing.Point(486, 63);
            this.numOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOcjena.Name = "numOcjena";
            this.numOcjena.Size = new System.Drawing.Size(34, 20);
            this.numOcjena.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ocjena:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 350);
            this.dataGridView1.TabIndex = 36;
            // 
            // PodaciEkipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(826, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOcjena);
            this.Controls.Add(this.btnSalji);
            this.Controls.Add(this.lblKotizacija);
            this.Controls.Add(this.numRezultat);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPodaciClanaNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodaciEkipe";
            this.Text = "PodaciEkipe";
            ((System.ComponentModel.ISupportInitialize)(this.numRezultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalji;
        private System.Windows.Forms.Label lblKotizacija;
        private System.Windows.Forms.NumericUpDown numRezultat;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblPodaciClanaNaslov;
        private System.Windows.Forms.NumericUpDown numOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}