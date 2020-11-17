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
    public partial class FavouriteMenu : Form
    {
        public FavouriteMenu()
        {
            InitializeComponent();
            LoadData();
        }

        private void FavouriteMenu_Load(object sender, EventArgs e)
        {

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
                        cmd.CommandText = @"Select menu.id_menu, menu.namamenu, COUNT(menu.id_menu) AS totalpesanan  From menu INNER JOIN detailorder ON menu.id_menu = detailorder.id_menu GROUP BY menu.id_menu, menu.namamenu ORDER BY totalpesanan DESC";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                          reader["id_menu"].ToString(),
                                          reader["namamenu"].ToString(),
                                          reader["totalpesanan"].ToString()
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
