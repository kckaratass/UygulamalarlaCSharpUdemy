namespace Hastane_Yonetim_Projesi
{
    partial class FrmDoktorPaneli
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 36);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(87, 76);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(162, 36);
            this.txtSurname.TabIndex = 6;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(87, 120);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(162, 36);
            this.cmbBranch.TabIndex = 7;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(87, 166);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(162, 36);
            this.mskTC.TabIndex = 8;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 36);
            this.txtPassword.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 336);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.Location = new System.Drawing.Point(88, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(88, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Location = new System.Drawing.Point(88, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(779, 390);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}