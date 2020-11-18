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
    public partial class AllTransaction : Form
    {
        public AllTransaction()
        {
            InitializeComponent();
        }

        private void AllTransaction_Load(object sender, EventArgs e)
        {
            LoadData();
            int sum = 0;
            for (int i = 0; i < dgvData.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvData.Rows[i].Cells["totalorder"].Value);
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
                        cmd.CommandText = @"Select id_order, nomormeja, totalorder, tanggalorder From orders ORDER BY id_order DESC";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                          reader["id_order"].ToString(),
                                          reader["nomormeja"].ToString(),
                                          reader["totalorder"].ToString()
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
    }
}
