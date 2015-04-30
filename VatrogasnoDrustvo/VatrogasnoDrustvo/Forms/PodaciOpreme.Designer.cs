namespace VatrogasnoDrustvo.InputForms
{
    partial class PodaciOpreme
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblPodaciClanaNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblVrsta
            // 
            this.lblVrsta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrsta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVrsta.Location = new System.Drawing.Point(97, 113);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(109, 20);
            this.lblVrsta.TabIndex = 1;
            this.lblVrsta.Text = "Vrsta opreme:";
            // 
            // lblPodaciClanaNaslov
            // 
            this.lblPodaciClanaNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPodaciClanaNaslov.AutoSize = true;
            this.lblPodaciClanaNaslov.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciClanaNaslov.ForeColor = System.Drawing.Color.White;
            this.lblPodaciClanaNaslov.Location = new System.Drawing.Point(78, 36);
            this.lblPodaciClanaNaslov.Name = "lblPodaciClanaNaslov";
            this.lblPodaciClanaNaslov.Size = new System.Drawing.Size(475, 37);
            this.lblPodaciClanaNaslov.TabIndex = 9;
            this.lblPodaciClanaNaslov.Text = "Izaberite vrstu iz liste i unesite podatke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(236, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "OSTATAK SE GENERIRA";
            // 
            // PodaciOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(647, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPodaciClanaNaslov);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.comboBox1);
            this.Name = "PodaciOpreme";
            this.Text = "PodaciOpreme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblPodaciClanaNaslov;
        private System.Windows.Forms.Label label1;
    }
}