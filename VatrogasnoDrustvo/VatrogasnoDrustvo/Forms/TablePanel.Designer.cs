namespace VatrogasnoDrustvo
{
    /**
     * User kontrola za tablični prikaz formi.
     */
    partial class TablePanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSecondDegree = new System.Windows.Forms.Button();
            this.btnFirstDegree = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchOprema = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvDBData = new System.Windows.Forms.DataGridView();
            this.lblBase = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.btnSecondDegree);
            this.pnlMain.Controls.Add(this.btnFirstDegree);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lblSearchOprema);
            this.pnlMain.Controls.Add(this.btnDodaj);
            this.pnlMain.Controls.Add(this.dgvDBData);
            this.pnlMain.Controls.Add(this.lblBase);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(997, 481);
            this.pnlMain.TabIndex = 6;
            // 
            // btnSecondDegree
            // 
            this.btnSecondDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSecondDegree.Location = new System.Drawing.Point(21, 437);
            this.btnSecondDegree.Name = "btnSecondDegree";
            this.btnSecondDegree.Size = new System.Drawing.Size(133, 32);
            this.btnSecondDegree.TabIndex = 7;
            this.btnSecondDegree.Text = "btnSecondDegree";
            this.btnSecondDegree.UseVisualStyleBackColor = true;
            this.btnSecondDegree.Visible = false;
            // 
            // btnFirstDegree
            // 
            this.btnFirstDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstDegree.Location = new System.Drawing.Point(713, 437);
            this.btnFirstDegree.Name = "btnFirstDegree";
            this.btnFirstDegree.Size = new System.Drawing.Size(133, 32);
            this.btnFirstDegree.TabIndex = 6;
            this.btnFirstDegree.Text = "btnFirstDegree";
            this.btnFirstDegree.UseVisualStyleBackColor = true;
            this.btnFirstDegree.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(788, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearchOprema
            // 
            this.lblSearchOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchOprema.AutoSize = true;
            this.lblSearchOprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchOprema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchOprema.Location = new System.Drawing.Point(715, 54);
            this.lblSearchOprema.Name = "lblSearchOprema";
            this.lblSearchOprema.Size = new System.Drawing.Size(67, 17);
            this.lblSearchOprema.TabIndex = 4;
            this.lblSearchOprema.Text = "Pretraga:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(852, 437);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(133, 32);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvDBData
            // 
            this.dgvDBData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDBData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDBData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDBData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDBData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDBData.Location = new System.Drawing.Point(21, 87);
            this.dgvDBData.MinimumSize = new System.Drawing.Size(100, 0);
            this.dgvDBData.Name = "dgvDBData";
            this.dgvDBData.Size = new System.Drawing.Size(964, 334);
            this.dgvDBData.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBase.Location = new System.Drawing.Point(12, 17);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(176, 54);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "lblBase";
            // 
            // TablePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.pnlMain);
            this.Name = "TablePanel";
            this.Size = new System.Drawing.Size(997, 481);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvDBData;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblSearchOprema;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFirstDegree;
        private System.Windows.Forms.Button btnSecondDegree;
    }
}
