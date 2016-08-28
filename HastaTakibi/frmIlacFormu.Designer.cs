namespace HastaTakibi
{
    partial class frmIlacFormu
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
            this.gbIlacListesi = new System.Windows.Forms.GroupBox();
            this.lbIlacListesi = new System.Windows.Forms.ListBox();
            this.gbIlacEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIlacListesi.SuspendLayout();
            this.gbIlacEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIlacListesi
            // 
            this.gbIlacListesi.Controls.Add(this.lbIlacListesi);
            this.gbIlacListesi.Location = new System.Drawing.Point(13, 13);
            this.gbIlacListesi.Name = "gbIlacListesi";
            this.gbIlacListesi.Size = new System.Drawing.Size(209, 282);
            this.gbIlacListesi.TabIndex = 0;
            this.gbIlacListesi.TabStop = false;
            this.gbIlacListesi.Text = "İlaç Listesi";
            // 
            // lbIlacListesi
            // 
            this.lbIlacListesi.FormattingEnabled = true;
            this.lbIlacListesi.Location = new System.Drawing.Point(17, 29);
            this.lbIlacListesi.Name = "lbIlacListesi";
            this.lbIlacListesi.Size = new System.Drawing.Size(173, 225);
            this.lbIlacListesi.TabIndex = 0;
            // 
            // gbIlacEkleme
            // 
            this.gbIlacEkleme.Controls.Add(this.btnEkle);
            this.gbIlacEkleme.Controls.Add(this.txtName);
            this.gbIlacEkleme.Controls.Add(this.label1);
            this.gbIlacEkleme.Location = new System.Drawing.Point(246, 13);
            this.gbIlacEkleme.Name = "gbIlacEkleme";
            this.gbIlacEkleme.Size = new System.Drawing.Size(257, 282);
            this.gbIlacEkleme.TabIndex = 1;
            this.gbIlacEkleme.TabStop = false;
            this.gbIlacEkleme.Text = "İlaç Ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaTakibi.Properties.Resources.add198;
            this.btnEkle.Location = new System.Drawing.Point(161, 158);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 55);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(22, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // frmIlacFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 336);
            this.Controls.Add(this.gbIlacEkleme);
            this.Controls.Add(this.gbIlacListesi);
            this.Name = "frmIlacFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Formu";
            this.Load += new System.EventHandler(this.frmIlacFormu_Load);
            this.gbIlacListesi.ResumeLayout(false);
            this.gbIlacEkleme.ResumeLayout(false);
            this.gbIlacEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIlacListesi;
        private System.Windows.Forms.ListBox lbIlacListesi;
        private System.Windows.Forms.GroupBox gbIlacEkleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}