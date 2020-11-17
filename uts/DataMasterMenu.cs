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
    public partial class DataMasterMenu : Form
    {
        public DataMasterMenu()
        {
            InitializeComponent();
        }

        private void DataMasterMenu_Load(object sender, EventArgs e)
        {
            LoadData();
            autoID();
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
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
                        cmd.CommandText = @"Select id_menu, namamenu, harga From menu oRDER BY id_menu ASC";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                          reader["id_menu"].ToString(),
                                          reader["namamenu"].ToString(),
                                          reader["harga"].ToString()
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

        private void autoID()
        {
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT TOP 1 * FROM menu ORDER BY id_menu DESC";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txt_idmenu.Text = Convert.ToString(Convert.ToInt32(reader["id_menu"].ToString())+1);
                            }
                        }
                    }
                }
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (this.txt_namamenu.Text == "")
            {
                MessageBox.Show("Sorry, Nama Menu Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_namamenu.Focus();
            }
            else if (txt_harga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Harga Menu Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_harga.Focus();
            }
            else
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Insert Into menu Values (@namamenu,@harga)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@namamenu", txt_namamenu.Text);
                        cmd.Parameters.AddWithValue("@harga", txt_harga.Text);
                        int recAffeced = cmd.ExecuteNonQuery();
                        if (recAffeced > 0)
                        {
                            this.dgvData.DataSource = null;
                            this.dgvData.Rows.Clear();
                            LoadData();
                            txt_namamenu.Text = "";
                            txt_harga.Text = "";
                            txt_namamenu.Focus();
                            autoID();
                            MessageBox.Show("Data Berhasil Ditambah", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                txt_idmenu.Text = row.Cells[0].Value.ToString();
                txt_namamenu.Text = row.Cells[1].Value.ToString();
                txt_harga.Text = row.Cells[2].Value.ToString();
                btn_simpan.Enabled = false;
                btn_edit.Enabled = true;
                btn_hapus.Enabled = true;
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE From menu Where id_menu =  @idmenu";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idmenu", txt_idmenu.Text);
                    int recAffeced = cmd.ExecuteNonQuery();
                    if (recAffeced > 0)
                    {
                        this.dgvData.DataSource = null;
                        this.dgvData.Rows.Clear();
                        LoadData();
                        txt_namamenu.Text = "";
                        txt_harga.Text = "";
                        txt_namamenu.Focus();
                        autoID();
                        btn_edit.Enabled = false;
                        btn_hapus.Enabled = false;
                        btn_simpan.Enabled = true;
                        MessageBox.Show("Data Berhasil Dihapus", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.txt_namamenu.Text == "")
            {
                MessageBox.Show("Sorry, Nama Menu Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_namamenu.Focus();
            }
            else if (txt_harga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Harga Menu Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_harga.Focus();
            }
            else
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"UPDATE menu SET namamenu = @namamenu, harga=@harga WHERE id_menu=@idmenu";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idmenu", txt_idmenu.Text);
                        cmd.Parameters.AddWithValue("@namamenu", txt_namamenu.Text);
                        cmd.Parameters.AddWithValue("@harga", txt_harga.Text);
                        int recAffeced = cmd.ExecuteNonQuery();
                        if (recAffeced > 0)
                        {
                            this.dgvData.DataSource = null;
                            this.dgvData.Rows.Clear();
                            LoadData();
                            MessageBox.Show("Data Berhasil Diubah", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
