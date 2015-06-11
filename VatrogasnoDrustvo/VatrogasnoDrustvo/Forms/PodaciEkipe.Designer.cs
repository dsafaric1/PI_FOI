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
            this.tablePanel1 = new VatrogasnoDrustvo.TablePanel();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Admin = false;
            this.tablePanel1.BackColor = System.Drawing.Color.Firebrick;
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Size = new System.Drawing.Size(980, 464);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.Table = null;
            // 
            // PodaciEkipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1004, 488);
            this.Controls.Add(this.tablePanel1);
            this.Name = "PodaciEkipe";
            this.Text = "PodaciEkipe";
            this.ResumeLayout(false);

        }

        #endregion

        private TablePanel tablePanel1;
    }
}