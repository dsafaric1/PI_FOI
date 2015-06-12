namespace VatrogasnoDrustvo.Forms
{
    partial class PodaciStavkeNarudzbe
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
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.lblPodaciNarudzbeNaslov = new System.Windows.Forms.Label();
            this.clbPodaciStavkeNarudzbe = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(335, 450);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(106, 26);
            this.btnDodajStavke.TabIndex = 43;
            this.btnDodajStavke.Text = "Dodaj stavke";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // lblPodaciNarudzbeNaslov
            // 
            this.lblPodaciNarudzbeNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPodaciNarudzbeNaslov.AutoSize = true;
            this.lblPodaciNarudzbeNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciNarudzbeNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciNarudzbeNaslov.Location = new System.Drawing.Point(328, 9);
            this.lblPodaciNarudzbeNaslov.Name = "lblPodaciNarudzbeNaslov";
            this.lblPodaciNarudzbeNaslov.Size = new System.Drawing.Size(113, 37);
            this.lblPodaciNarudzbeNaslov.TabIndex = 44;
            this.lblPodaciNarudzbeNaslov.Text = "Oprema";
            // 
            // clbPodaciStavkeNarudzbe
            // 
            this.clbPodaciStavkeNarudzbe.BackColor = System.Drawing.Color.Firebrick;
            this.clbPodaciStavkeNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPodaciStavkeNarudzbe.ColumnWidth = 220;
            this.clbPodaciStavkeNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPodaciStavkeNarudzbe.ForeColor = System.Drawing.Color.White;
            this.clbPodaciStavkeNarudzbe.FormattingEnabled = true;
            this.clbPodaciStavkeNarudzbe.Location = new System.Drawing.Point(12, 68);
            this.clbPodaciStavkeNarudzbe.MultiColumn = true;
            this.clbPodaciStavkeNarudzbe.Name = "clbPodaciStavkeNarudzbe";
            this.clbPodaciStavkeNarudzbe.Size = new System.Drawing.Size(721, 357);
            this.clbPodaciStavkeNarudzbe.TabIndex = 45;
            // 
            // PodaciStavkeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.clbPodaciStavkeNarudzbe);
            this.Controls.Add(this.lblPodaciNarudzbeNaslov);
            this.Controls.Add(this.btnDodajStavke);
            this.Name = "PodaciStavkeNarudzbe";
            this.Text = "PodaciStavkeNarudzbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.Label lblPodaciNarudzbeNaslov;
        private System.Windows.Forms.CheckedListBox clbPodaciStavkeNarudzbe;
    }
}