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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void dataPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTransaction frm2 = new DataTransaction();
            frm2.ShowDialog();
        }

        private void masterMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataMasterMenu frm2 = new DataMasterMenu();
            frm2.ShowDialog();
        }

        private void laporanPenjualanHarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanPenjualan frm2 = new LaporanPenjualan();
            frm2.ShowDialog();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllTransaction frm2 = new AllTransaction();
            frm2.ShowDialog();
        }
    }
}
