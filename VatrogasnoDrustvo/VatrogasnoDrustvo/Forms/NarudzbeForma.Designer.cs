﻿namespace VatrogasnoDrustvo.Forme
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
            this.pnlNarudzbe = new VatrogasnoDrustvo.TablePanel();
            this.SuspendLayout();
            // 
            // pnlNarudzbe
            // 
            this.pnlNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNarudzbe.BackColor = System.Drawing.Color.Firebrick;
            this.pnlNarudzbe.Location = new System.Drawing.Point(0, 1);
            this.pnlNarudzbe.Name = "pnlNarudzbe";
            this.pnlNarudzbe.Size = new System.Drawing.Size(1021, 505);
            this.pnlNarudzbe.TabIndex = 0;
            // 
            // NarudzbeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 505);
            this.Controls.Add(this.pnlNarudzbe);
            this.Name = "NarudzbeForma";
            this.Text = "NarudzbeForma";
            this.ResumeLayout(false);

        }

        #endregion

        private TablePanel pnlNarudzbe;
    }
}