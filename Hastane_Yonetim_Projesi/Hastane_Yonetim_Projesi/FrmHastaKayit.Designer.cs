namespace Hastane_Yonetim_Projesi
{
    partial class FrmHastaKayit
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(186, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(172, 36);
            this.txtSurname.TabIndex = 9;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(186, 140);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(172, 36);
            this.mskTC.TabIndex = 8;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta Telefon No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "T.C Kimlik No:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 36);
            this.txtPassword.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hasta Cinsiyet:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 36);
            this.txtName.TabIndex = 18;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(186, 180);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(172, 36);
            this.mskPhoneNumber.TabIndex = 20;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbGender.Location = new System.Drawing.Point(186, 264);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(172, 36);
            this.cmbGender.TabIndex = 21;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.Location = new System.Drawing.Point(186, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 39);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Kayıt Ol";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(418, 504);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.mskPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
//            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnLogin;
    }
}