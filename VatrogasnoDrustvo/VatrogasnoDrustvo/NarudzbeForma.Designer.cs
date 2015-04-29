namespace VatrogasnoDrustvo
{
    partial class NarudzbeForma
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
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.btnDobavljaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaseNaslov
            // 
            this.lblBaseNaslov.Size = new System.Drawing.Size(225, 49);
            this.lblBaseNaslov.Text = "Narudzbe";
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(1006, 628);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(105, 31);
            this.btnGeneriraj.TabIndex = 8;
            this.btnGeneriraj.Text = "Generiraj PDF";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            // 
            // btnDobavljaci
            // 
            this.btnDobavljaci.Location = new System.Drawing.Point(33, 628);
            this.btnDobavljaci.Name = "btnDobavljaci";
            this.btnDobavljaci.Size = new System.Drawing.Size(103, 31);
            this.btnDobavljaci.TabIndex = 9;
            this.btnDobavljaci.Text = "Dobavljači";
            this.btnDobavljaci.UseVisualStyleBackColor = true;
            this.btnDobavljaci.Click += new System.EventHandler(this.btnDobavljaci_Click);
            // 
            // NarudzbeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1362, 719);
            this.Controls.Add(this.btnDobavljaci);
            this.Controls.Add(this.btnGeneriraj);
            this.Name = "NarudzbeForma";
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.lblBaseSearch, 0);
            this.Controls.SetChildIndex(this.txtBaseSearch, 0);
            this.Controls.SetChildIndex(this.lblBaseNaslov, 0);
            this.Controls.SetChildIndex(this.btnGeneriraj, 0);
            this.Controls.SetChildIndex(this.btnDobavljaci, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.Button btnDobavljaci;
    }
}
