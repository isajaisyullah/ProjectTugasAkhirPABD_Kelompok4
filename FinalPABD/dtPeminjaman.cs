using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPABD
{
    public partial class dtPeminjaman : Form
    {
        public dtPeminjaman()
        {
            InitializeComponent();
        }

        private void dtPeminjaman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Peminjaman' table. You can move, or remove it, as needed.
            this.peminjamanTableAdapter.Fill(this.iniPerpusDataSet.Peminjaman);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DataBuku().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new dtAnggota().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new tmAnggota().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Peminjaman().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Pengembalian().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
