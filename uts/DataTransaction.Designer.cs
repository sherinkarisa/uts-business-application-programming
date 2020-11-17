namespace uts
{
    partial class DataTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idtransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomormeja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalbayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransaksi,
            this.idorder,
            this.nomormeja,
            this.tanggalorder,
            this.nominalbayar,
            this.totalorder});
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.dgvData.Location = new System.Drawing.Point(12, 74);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(776, 334);
            this.dgvData.TabIndex = 22;
            // 
            // idtransaksi
            // 
            this.idtransaksi.HeaderText = "ID. Transaksi";
            this.idtransaksi.Name = "idtransaksi";
            this.idtransaksi.ReadOnly = true;
            // 
            // idorder
            // 
            this.idorder.HeaderText = "ID. Order";
            this.idorder.Name = "idorder";
            this.idorder.ReadOnly = true;
            this.idorder.Width = 50;
            // 
            // nomormeja
            // 
            this.nomormeja.HeaderText = "Table No.";
            this.nomormeja.Name = "nomormeja";
            this.nomormeja.ReadOnly = true;
            // 
            // tanggalorder
            // 
            this.tanggalorder.HeaderText = "Tanggal Order";
            this.tanggalorder.Name = "tanggalorder";
            this.tanggalorder.ReadOnly = true;
            this.tanggalorder.Width = 150;
            // 
            // nominalbayar
            // 
            this.nominalbayar.HeaderText = "Nominal Bayar";
            this.nominalbayar.Name = "nominalbayar";
            this.nominalbayar.ReadOnly = true;
            this.nominalbayar.Width = 200;
            // 
            // totalorder
            // 
            this.totalorder.HeaderText = "Total Order";
            this.totalorder.Name = "totalorder";
            this.totalorder.ReadOnly = true;
            this.totalorder.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kuphi Cafe";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(720, 411);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(14, 13);
            this.txt_total.TabIndex = 24;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Bayar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(331, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data Transactions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 39);
            this.label5.TabIndex = 27;
            this.label5.Text = "_______________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(476, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 39);
            this.label3.TabIndex = 28;
            this.label3.Text = "_______________";
            // 
            // DataTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transaction";
            this.Load += new System.EventHandler(this.DataTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomormeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalbayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalorder;
    }
}