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
using System.IO;

namespace uts
{
    public partial class Form1 : Form
    {

        string order_id = "";
        public Form1()
        {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
            button3.Enabled = false;
        }
        private bool imgColumn = true;

        private void LoadData()
        {
            try
            {
                if (imgColumn == true)
                {
                    DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
                    dgvimgcol.HeaderText = "Photo";
                    dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgvData.Columns.Add(dgvimgcol);
                    imgColumn = false;
                }
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select id_menu, namamenu, harga, foto From menu ORDER BY namamenu ASC";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new [] {
                                          reader["id_menu"].ToString(),
                                          reader["namamenu"].ToString(),
                                          reader["harga"].ToString(),
                                          reader["foto"]
                                     });
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            addPicture();
        }

        private void addPicture()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[3].Value.ToString() != "")
                {
                    byte[] images = (byte[])row.Cells[3].Value;

                    MemoryStream mstream = new MemoryStream(images);
                    Image img = Image.FromStream(mstream);
                    this.dgvData.Columns[3].Visible = false;

                    ((DataGridViewImageCell)row.Cells[4]).Value = img;

                    row.Height = 80;
                }


            }
        }

        private void showDataMenu(string id_menu)
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select id_menu, namamenu, harga, foto From menu Where id_menu = @idmenu";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idmenu", id_menu);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    dataGridView1.Rows.Add(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString(), ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value.ToString(), reader["harga"].ToString(), txt_qty.Text, Convert.ToString(Convert.ToInt32(reader["harga"].ToString()) * Convert.ToInt32(txt_qty.Text)));
                                    int sum = 0;
                                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                                    {
                                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["subtotal"].Value);
                                    }
                                    txt_total.Text = sum.ToString();
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

        private void LoadDataToComboBox()
        {

            IDictionary<string, string> comboSource = new Dictionary<string, string>();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {

                        cmd.Connection = conn;
                        cmd.CommandText = @"Select id_menu,namamenu From menu";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    comboSource.Add(reader["id_menu"].ToString(), reader["namamenu"].ToString());
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

            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                LoadData();
                LoadDataToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_qty.Text.Equals(""))
            {
                MessageBox.Show("Quantity Tidak Boleh Kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (txt_qty.Text.Equals("0"))
                {
                    MessageBox.Show("Quantity Tidak Boleh 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool cek = false;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn1"].Value.ToString().Equals(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString()))
                        {
                            cek = true;
                            MessageBox.Show("Menu Sudah Dipilih", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    if (!cek)
                        showDataMenu(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString());

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["subtotal"].Value);
                }
                txt_total.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Belum Ada Yang Dipilih", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_nomormeja.Text.Equals(""))
            {
                MessageBox.Show("Masukkan Nomor Meja Anda Terlebih Dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tunggu Sebentar, Pelayan Akan Mendatangi Meja Anda", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_nomormeja.Text.Equals(""))
            {
                MessageBox.Show("Masukkan Nomor Meja Anda Terlebih Dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridView1.Rows.Count.ToString().Equals("0"))
                {
                    MessageBox.Show("Belum Ada Menu Yang Dipesan", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = @"Insert Into orders Values (@nomormeja,@totalorder,@tanggalorder)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@nomormeja", txt_nomormeja.Text);
                            cmd.Parameters.AddWithValue("@totalorder", txt_total.Text);
                            cmd.Parameters.AddWithValue("@tanggalorder", DateTime.Today);
                            int recAffeced = cmd.ExecuteNonQuery();

                        }
                    }
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {

                            cmd.Connection = conn;
                            cmd.CommandText = @"SELECT TOP 1 * FROM orders ORDER BY id_order DESC";
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        order_id = reader["id_order"].ToString();
                                    }
                                }
                                else
                                {
                                    order_id = "1";
                                }
                            }
                        }
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        using (var conn = new Connection().CreateAndOpenConnection())
                        {
                            using (var cmd = new SqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.CommandText = @"Insert Into detailorder Values (@id_order, @id_menu, @qty, @subtotal)";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@id_order", order_id);
                                cmd.Parameters.AddWithValue("@id_menu", dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                                cmd.Parameters.AddWithValue("@qty", txt_qty.Text);
                                cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells["subtotal"].Value.ToString());
                                int recAffeced = cmd.ExecuteNonQuery();

                            }
                        }
                    }
                    txt_nomormeja.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button3.Enabled = true;
                    MessageBox.Show("Order Berhasil Dilakukan, Silahkan Tunggu Pesanan Anda Datang", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_nominalbayar.Text.Equals(""))
            {
                MessageBox.Show("Nominal Bayar Tidak Boleh Kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Convert.ToInt32(txt_nominalbayar.Text) < Convert.ToInt32(txt_total.Text))
                {
                    MessageBox.Show("Nominal Bayar Tidak Boleh Lebih Kecil Dari Total Order Anda", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = @"Insert Into transactions Values (@id_order, @nominalbayar)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id_order", order_id);
                            cmd.Parameters.AddWithValue("@nominalbayar", txt_nominalbayar.Text);
                            int recAffeced = cmd.ExecuteNonQuery();
                            txt_nominalbayar.Enabled = false;
                            button3.Enabled = false;
                            MessageBox.Show("Bill Anda Berhasil Dibuat, Silahkan Tunggu Pelayan Memberikan Struk Pembayaran Kepada Anda", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FavouriteMenu frm2 = new FavouriteMenu();
            frm2.ShowDialog();
        }
    }
}
