namespace HastaTakibi
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDoktorKayit = new System.Windows.Forms.Button();
            this.btnHastalikKayit = new System.Windows.Forms.Button();
            this.btnBolumKayit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandevuTarihcesi = new System.Windows.Forms.Button();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.btnIlacKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(133, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "İlaç Kayıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Randevu Tarihçesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(133, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "İlaç Ver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(490, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bölüm Kayıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(490, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hastalık Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(490, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doktor Kayıt";
            // 
            // btnDoktorKayit
            // 
            this.btnDoktorKayit.Image = global::HastaTakibi.Properties.Resources.doktor_kayıt;
            this.btnDoktorKayit.Location = new System.Drawing.Point(378, 186);
            this.btnDoktorKayit.Name = "btnDoktorKayit";
            this.btnDoktorKayit.Size = new System.Drawing.Size(87, 70);
            this.btnDoktorKayit.TabIndex = 2;
            this.btnDoktorKayit.UseVisualStyleBackColor = true;
            this.btnDoktorKayit.Click += new System.EventHandler(this.btnDoktorKayit_Click);
            // 
            // btnHastalikKayit
            // 
            this.btnHastalikKayit.Image = global::HastaTakibi.Properties.Resources.hastalık_kayıt;
            this.btnHastalikKayit.Location = new System.Drawing.Point(378, 99);
            this.btnHastalikKayit.Name = "btnHastalikKayit";
            this.btnHastalikKayit.Size = new System.Drawing.Size(87, 70);
            this.btnHastalikKayit.TabIndex = 2;
            this.btnHastalikKayit.UseVisualStyleBackColor = true;
            this.btnHastalikKayit.Click += new System.EventHandler(this.btnHastalikKayit_Click);
            // 
            // btnBolumKayit
            // 
            this.btnBolumKayit.Image = global::HastaTakibi.Properties.Resources.bölüm_kayıt;
            this.btnBolumKayit.Location = new System.Drawing.Point(378, 12);
            this.btnBolumKayit.Name = "btnBolumKayit";
            this.btnBolumKayit.Size = new System.Drawing.Size(87, 70);
            this.btnBolumKayit.TabIndex = 2;
            this.btnBolumKayit.UseVisualStyleBackColor = true;
            this.btnBolumKayit.Click += new System.EventHandler(this.btnBolumKayit_Click);
            // 
            // button1
            // 
            this.button1.Image = global::HastaTakibi.Properties.Resources.ilaç_ver;
            this.button1.Location = new System.Drawing.Point(30, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandevuTarihcesi
            // 
            this.btnRandevuTarihcesi.Image = global::HastaTakibi.Properties.Resources.randevu_tarihçesi;
            this.btnRandevuTarihcesi.Location = new System.Drawing.Point(30, 186);
            this.btnRandevuTarihcesi.Name = "btnRandevuTarihcesi";
            this.btnRandevuTarihcesi.Size = new System.Drawing.Size(87, 70);
            this.btnRandevuTarihcesi.TabIndex = 2;
            this.btnRandevuTarihcesi.UseVisualStyleBackColor = true;
            this.btnRandevuTarihcesi.Click += new System.EventHandler(this.btnRandevuTarihcesi_Click);
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.Image = global::HastaTakibi.Properties.Resources.hasta_kayıt;
            this.btnHastaKayit.Location = new System.Drawing.Point(30, 12);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(87, 70);
            this.btnHastaKayit.TabIndex = 1;
            this.btnHastaKayit.UseVisualStyleBackColor = true;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // btnIlacKayit
            // 
            this.btnIlacKayit.Image = global::HastaTakibi.Properties.Resources.ilaç_kayıt;
            this.btnIlacKayit.Location = new System.Drawing.Point(30, 99);
            this.btnIlacKayit.Name = "btnIlacKayit";
            this.btnIlacKayit.Size = new System.Drawing.Size(87, 70);
            this.btnIlacKayit.TabIndex = 1;
            this.btnIlacKayit.UseVisualStyleBackColor = true;
            this.btnIlacKayit.Click += new System.EventHandler(this.btnIlacKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 379);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoktorKayit);
            this.Controls.Add(this.btnHastalikKayit);
            this.Controls.Add(this.btnBolumKayit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRandevuTarihcesi);
            this.Controls.Add(this.btnHastaKayit);
            this.Controls.Add(this.btnIlacKayit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Takip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIlacKayit;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.Button btnRandevuTarihcesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBolumKayit;
        private System.Windows.Forms.Button btnHastalikKayit;
        private System.Windows.Forms.Button btnDoktorKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

