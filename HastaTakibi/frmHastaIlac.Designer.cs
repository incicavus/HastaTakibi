namespace HastaTakibi
{
    partial class frmHastaIlac
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
            this.gbHastaIlac = new System.Windows.Forms.GroupBox();
            this.gvSonuc = new System.Windows.Forms.DataGridView();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.gbHastaIlac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHastaIlac
            // 
            this.gbHastaIlac.Controls.Add(this.gvSonuc);
            this.gbHastaIlac.Controls.Add(this.btnBul);
            this.gbHastaIlac.Controls.Add(this.txtTC);
            this.gbHastaIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHastaIlac.Location = new System.Drawing.Point(0, 0);
            this.gbHastaIlac.Name = "gbHastaIlac";
            this.gbHastaIlac.Size = new System.Drawing.Size(933, 275);
            this.gbHastaIlac.TabIndex = 0;
            this.gbHastaIlac.TabStop = false;
            this.gbHastaIlac.Text = "Hasta-İlaç Bilgileri";
            // 
            // gvSonuc
            // 
            this.gvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSonuc.Location = new System.Drawing.Point(12, 62);
            this.gvSonuc.Name = "gvSonuc";
            this.gvSonuc.Size = new System.Drawing.Size(909, 197);
            this.gvSonuc.TabIndex = 2;
            // 
            // btnBul
            // 
            this.btnBul.Image = global::HastaTakibi.Properties.Resources.microscope13;
            this.btnBul.Location = new System.Drawing.Point(864, 16);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(57, 40);
            this.btnBul.TabIndex = 1;
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(621, 22);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(214, 26);
            this.txtTC.TabIndex = 0;
            // 
            // frmHastaIlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 287);
            this.Controls.Add(this.gbHastaIlac);
            this.Name = "frmHastaIlac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İlaç Formu";
            this.Load += new System.EventHandler(this.frmHastaIlac_Load);
            this.gbHastaIlac.ResumeLayout(false);
            this.gbHastaIlac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHastaIlac;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.DataGridView gvSonuc;
    }
}