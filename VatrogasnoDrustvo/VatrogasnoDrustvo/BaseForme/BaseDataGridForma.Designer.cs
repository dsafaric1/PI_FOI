namespace VatrogasnoDrustvo
{
    partial class BaseDataGridForma
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
        protected void InitializeComponent()
        {
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.lblBaseSearch = new System.Windows.Forms.Label();
            this.txtBaseSearch = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBaseNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBase
            // 
            this.dgvBase.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Location = new System.Drawing.Point(64, 132);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.Size = new System.Drawing.Size(1253, 473);
            this.dgvBase.TabIndex = 1;
            // 
            // lblBaseSearch
            // 
            this.lblBaseSearch.AutoSize = true;
            this.lblBaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseSearch.ForeColor = System.Drawing.Color.White;
            this.lblBaseSearch.Location = new System.Drawing.Point(932, 96);
            this.lblBaseSearch.Name = "lblBaseSearch";
            this.lblBaseSearch.Size = new System.Drawing.Size(64, 17);
            this.lblBaseSearch.TabIndex = 4;
            this.lblBaseSearch.Text = "Search:";
            // 
            // txtBaseSearch
            // 
            this.txtBaseSearch.Location = new System.Drawing.Point(1016, 95);
            this.txtBaseSearch.Name = "txtBaseSearch";
            this.txtBaseSearch.Size = new System.Drawing.Size(180, 20);
            this.txtBaseSearch.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodaj.Location = new System.Drawing.Point(1212, 628);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 31);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // lblBaseNaslov
            // 
            this.lblBaseNaslov.AutoSize = true;
            this.lblBaseNaslov.Font = new System.Drawing.Font("DejaVu Sans", 30.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBaseNaslov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBaseNaslov.Location = new System.Drawing.Point(38, 49);
            this.lblBaseNaslov.Name = "lblBaseNaslov";
            this.lblBaseNaslov.Size = new System.Drawing.Size(257, 49);
            this.lblBaseNaslov.TabIndex = 7;
            this.lblBaseNaslov.Text = "BaseForma";
            // 
            // BaseDataGridForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.lblBaseNaslov);
            this.Controls.Add(this.txtBaseSearch);
            this.Controls.Add(this.lblBaseSearch);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.btnDodaj);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BaseDataGridForma";
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.dgvBase, 0);
            this.Controls.SetChildIndex(this.lblBaseSearch, 0);
            this.Controls.SetChildIndex(this.txtBaseSearch, 0);
            this.Controls.SetChildIndex(this.lblBaseNaslov, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnDodaj;
        protected System.Windows.Forms.DataGridView dgvBase;
        protected System.Windows.Forms.Label lblBaseSearch;
        protected System.Windows.Forms.TextBox txtBaseSearch;
        protected System.Windows.Forms.Label lblBaseNaslov;

    }
}