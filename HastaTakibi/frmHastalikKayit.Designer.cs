namespace HastaTakibi
{
    partial class frmHastalikKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastalik = new System.Windows.Forms.TextBox();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hastalık:";
            // 
            // txtHastalik
            // 
            this.txtHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastalik.Location = new System.Drawing.Point(159, 140);
            this.txtHastalik.Name = "txtHastalik";
            this.txtHastalik.Size = new System.Drawing.Size(217, 30);
            this.txtHastalik.TabIndex = 2;
            // 
            // cbBolum
            // 
            this.cbBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Location = new System.Drawing.Point(159, 60);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(217, 33);
            this.cbBolum.TabIndex = 3;
            this.cbBolum.SelectedIndexChanged += new System.EventHandler(this.cbBolum_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaTakibi.Properties.Resources.add198;
            this.btnEkle.Location = new System.Drawing.Point(310, 217);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 54);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmHastalikKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 322);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.txtHastalik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHastalikKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastlık Kayıt Formu";
            this.Load += new System.EventHandler(this.frmHastalikKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastalik;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.Button btnEkle;
    }
}