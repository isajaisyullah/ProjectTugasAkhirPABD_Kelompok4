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

namespace FinalPABD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

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

        private void button4_Click(object sender, EventArgs e)
        {
            new dtPeminjaman().Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.iniPerpusDataSet.Buku);
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.iniPerpusDataSet.Anggota);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
