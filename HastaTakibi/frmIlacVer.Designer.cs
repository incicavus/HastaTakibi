namespace HastaTakibi
{
    partial class frmIlacVer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.cbHastalik = new System.Windows.Forms.ComboBox();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lbIlacVer = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hastalık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih:";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(179, 43);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 23);
            this.txtTC.TabIndex = 2;
            // 
            // cbBolum
            // 
            this.cbBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Location = new System.Drawing.Point(179, 94);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(200, 24);
            this.cbBolum.TabIndex = 3;
            // 
            // cbHastalik
            // 
            this.cbHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHastalik.FormattingEnabled = true;
            this.cbHastalik.Location = new System.Drawing.Point(179, 146);
            this.cbHastalik.Name = "cbHastalik";
            this.cbHastalik.Size = new System.Drawing.Size(200, 24);
            this.cbHastalik.TabIndex = 4;
            // 
            // cbDoktor
            // 
            this.cbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(179, 198);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(200, 24);
            this.cbDoktor.TabIndex = 5;
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(179, 251);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 23);
            this.dtTarih.TabIndex = 6;
            // 
            // lbIlacVer
            // 
            this.lbIlacVer.FormattingEnabled = true;
            this.lbIlacVer.Location = new System.Drawing.Point(458, 43);
            this.lbIlacVer.Name = "lbIlacVer";
            this.lbIlacVer.Size = new System.Drawing.Size(199, 277);
            this.lbIlacVer.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaTakibi.Properties.Resources.add198;
            this.btnEkle.Location = new System.Drawing.Point(542, 371);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(72, 60);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmIlacVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 460);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbIlacVer);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.cbHastalik);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIlacVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Ver";
            this.Load += new System.EventHandler(this.frmIlacVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.ComboBox cbHastalik;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ListBox lbIlacVer;
        private System.Windows.Forms.Button btnEkle;
    }
}