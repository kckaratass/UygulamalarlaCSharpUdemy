namespace Bilgi_Yarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.LblDoğru = new System.Windows.Forms.Label();
            this.LblYanlış = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(470, 228);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnA.Location = new System.Drawing.Point(12, 246);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(222, 43);
            this.BtnA.TabIndex = 2;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnB.Location = new System.Drawing.Point(260, 246);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(222, 43);
            this.BtnB.TabIndex = 3;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = false;
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnC.Location = new System.Drawing.Point(12, 295);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(222, 43);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            // 
            // BtnD
            // 
            this.BtnD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnD.Location = new System.Drawing.Point(260, 295);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(222, 43);
            this.BtnD.TabIndex = 5;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = false;
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(519, 34);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(84, 24);
            this.lblSoruNo.TabIndex = 6;
            this.lblSoruNo.Text = "Soru No:";
            // 
            // LblDoğru
            // 
            this.LblDoğru.AutoSize = true;
            this.LblDoğru.Location = new System.Drawing.Point(519, 72);
            this.LblDoğru.Name = "LblDoğru";
            this.LblDoğru.Size = new System.Drawing.Size(69, 24);
            this.LblDoğru.TabIndex = 7;
            this.LblDoğru.Text = "Doğru:";
            // 
            // LblYanlış
            // 
            this.LblYanlış.AutoSize = true;
            this.LblYanlış.Location = new System.Drawing.Point(519, 110);
            this.LblYanlış.Name = "LblYanlış";
            this.LblYanlış.Size = new System.Drawing.Size(64, 24);
            this.LblYanlış.TabIndex = 8;
            this.LblYanlış.Text = "Yanlış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSonraki.Location = new System.Drawing.Point(514, 146);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(185, 40);
            this.BtnSonraki.TabIndex = 12;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = false;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(609, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(436, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(503, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblYanlış);
            this.Controls.Add(this.LblDoğru);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label LblDoğru;
        private System.Windows.Forms.Label LblYanlış;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

