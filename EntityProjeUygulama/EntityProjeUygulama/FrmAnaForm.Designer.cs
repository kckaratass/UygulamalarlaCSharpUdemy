namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.btnKategoriIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriIslemleri
            // 
            this.btnKategoriIslemleri.BackColor = System.Drawing.Color.White;
            this.btnKategoriIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnKategoriIslemleri.Location = new System.Drawing.Point(34, 23);
            this.btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            this.btnKategoriIslemleri.Size = new System.Drawing.Size(248, 134);
            this.btnKategoriIslemleri.TabIndex = 0;
            this.btnKategoriIslemleri.Text = "KATEGORİ İŞLEMLERİ";
            this.btnKategoriIslemleri.UseVisualStyleBackColor = false;
            this.btnKategoriIslemleri.Click += new System.EventHandler(this.btnKategoriIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.BackColor = System.Drawing.Color.White;
            this.btnUrunIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnUrunIslemleri.Location = new System.Drawing.Point(299, 23);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(248, 134);
            this.btnUrunIslemleri.TabIndex = 1;
            this.btnUrunIslemleri.Text = "ÜRÜN İŞLEMLERİ";
            this.btnUrunIslemleri.UseVisualStyleBackColor = false;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.White;
            this.btnIstatistik.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstatistik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnIstatistik.Location = new System.Drawing.Point(563, 23);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(248, 134);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İSTATİSTİKLER";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(834, 185);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnUrunIslemleri);
            this.Controls.Add(this.btnKategoriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnIstatistik;
    }
}