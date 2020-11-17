namespace uts
{
    partial class DataMasterMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idmenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_namamenu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID. Menu";
            // 
            // txt_idmenu
            // 
            this.txt_idmenu.BackColor = System.Drawing.Color.White;
            this.txt_idmenu.Enabled = false;
            this.txt_idmenu.Location = new System.Drawing.Point(109, 83);
            this.txt_idmenu.Name = "txt_idmenu";
            this.txt_idmenu.ReadOnly = true;
            this.txt_idmenu.Size = new System.Drawing.Size(189, 20);
            this.txt_idmenu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Menu";
            // 
            // txt_namamenu
            // 
            this.txt_namamenu.Location = new System.Drawing.Point(109, 133);
            this.txt_namamenu.Name = "txt_namamenu";
            this.txt_namamenu.Size = new System.Drawing.Size(189, 20);
            this.txt_namamenu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga";
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(109, 182);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(189, 20);
            this.txt_harga.TabIndex = 6;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(15, 376);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 36);
            this.btn_simpan.TabIndex = 7;
            this.btn_simpan.Text = "SAVE";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(121, 376);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 36);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Location = new System.Drawing.Point(223, 376);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 36);
            this.btn_hapus.TabIndex = 9;
            this.btn_hapus.Text = "DELETE";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.dgvData.Location = new System.Drawing.Point(327, 83);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(461, 329);
            this.dgvData.TabIndex = 10;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID. Menu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Menu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(324, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kuphi Cafe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(334, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Item Master Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 39);
            this.label5.TabIndex = 23;
            this.label5.Text = "_______________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(475, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 39);
            this.label7.TabIndex = 24;
            this.label7.Text = "_______________";
            // 
            // DataMasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_namamenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idmenu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataMasterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Master Menu";
            this.Load += new System.EventHandler(this.DataMasterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_namamenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}