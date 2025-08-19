namespace Hastane_Yonetim_Projesi
{
    partial class FrmBransPaneli
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Location = new System.Drawing.Point(108, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 36);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Location = new System.Drawing.Point(108, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 35);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.Location = new System.Drawing.Point(108, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 35);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 207);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(107, 70);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(162, 36);
            this.txtBranchName.TabIndex = 20;
            // 
            // txtBranchId
            // 
            this.txtBranchId.Location = new System.Drawing.Point(107, 28);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(162, 36);
            this.txtBranchId.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Branş Id:";
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(775, 252);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBransPaneli";
            this.Text = "FrmBransPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}