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
    public partial class DataBuku : Form
    {
        public DataBuku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
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

        private void DataBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.iniPerpusDataSet.Buku);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            new tambahBuku().Show();
            this.Hide();
        } 
        

        private void button10_Click_1(object sender, EventArgs e)
        {
            new edBuku().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
