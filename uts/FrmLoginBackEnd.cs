using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uts
{
    public partial class FrmLoginBackEnd : Form
    {
        public FrmLoginBackEnd()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (this.txtIDUser.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, ID User Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDUser.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Password User Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else
            {
                
                if(this.txtIDUser.Text.Trim() == "admin" && txtPassword.Text.Trim() == "123456")
                {
                    DashboardAdmin frm3 = new DashboardAdmin();
                    this.Hide();
                    frm3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Kombinasi username dan kata sandi masih salah ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
