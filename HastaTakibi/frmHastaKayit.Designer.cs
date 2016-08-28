namespace HastaTakibi
{
    partial class frmHastaKayit
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTCArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.gvHastaArama = new System.Windows.Forms.DataGridView();
            this.gbHastaArama = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHastaArama)).BeginInit();
            this.gbHastaArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim:";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(149, 44);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(224, 23);
            this.txtTC.TabIndex = 1;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(149, 93);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(224, 23);
            this.txtIsim.TabIndex = 2;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(149, 142);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(224, 23);
            this.txtSoyisim.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaTakibi.Properties.Resources.add198;
            this.btnEkle.Location = new System.Drawing.Point(479, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 61);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTCArama
            // 
            this.txtTCArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCArama.Location = new System.Drawing.Point(302, 45);
            this.txtTCArama.MaxLength = 11;
            this.txtTCArama.Name = "txtTCArama";
            this.txtTCArama.Size = new System.Drawing.Size(224, 21);
            this.txtTCArama.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(256, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // btnBul
            // 
            this.btnBul.Image = global::HastaTakibi.Properties.Resources.microscope13;
            this.btnBul.Location = new System.Drawing.Point(532, 22);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(65, 44);
            this.btnBul.TabIndex = 5;
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // gvHastaArama
            // 
            this.gvHastaArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHastaArama.Location = new System.Drawing.Point(6, 88);
            this.gvHastaArama.Name = "gvHastaArama";
            this.gvHastaArama.Size = new System.Drawing.Size(608, 135);
            this.gvHastaArama.TabIndex = 6;
            // 
            // gbHastaArama
            // 
            this.gbHastaArama.Controls.Add(this.gvHastaArama);
            this.gbHastaArama.Controls.Add(this.btnBul);
            this.gbHastaArama.Controls.Add(this.label4);
            this.gbHastaArama.Controls.Add(this.txtTCArama);
            this.gbHastaArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHastaArama.Location = new System.Drawing.Point(12, 189);
            this.gbHastaArama.Name = "gbHastaArama";
            this.gbHastaArama.Size = new System.Drawing.Size(620, 229);
            this.gbHastaArama.TabIndex = 5;
            this.gbHastaArama.TabStop = false;
            this.gbHastaArama.Text = "Hasta Arama";
            // 
            // frmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 430);
            this.Controls.Add(this.gbHastaArama);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Formu";
            this.Load += new System.EventHandler(this.frmHastaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHastaArama)).EndInit();
            this.gbHastaArama.ResumeLayout(false);
            this.gbHastaArama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTCArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView gvHastaArama;
        private System.Windows.Forms.GroupBox gbHastaArama;
    }
}