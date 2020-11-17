using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace uts
{
    public partial class DataTransaction : Form
    {
        public DataTransaction()
        {
            InitializeComponent();
        }

        private void DataTransaction_Load(object sender, EventArgs e)
        {
            LoadData();
            int sum = 0;
            for (int i = 0; i < dgvData.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvData.Rows[i].Cells["nominalbayar"].Value);
            }
            txt_total.Text = sum.ToString();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select transactions.id_transaction, transactions.id_order, orders.nomormeja, orders.tanggalorder, orders.totalorder, transactions.nominalbayar From transactions INNER JOIN orders ON transactions.id_order = orders.id_order ORDER BY transactions.id_transaction DESC";
                       
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                          reader["id_transaction"].ToString(),
                                          reader["id_order"].ToString(),
                                          reader["nomormeja"].ToString(),
                                          reader["tanggalorder"].ToString(),
                                          reader["totalorder"].ToString(),
                                          reader["nominalbayar"].ToString()
                                     });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bill Telah Berhasil Dicetak!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
