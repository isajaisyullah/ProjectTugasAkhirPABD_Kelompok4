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
    public partial class Pengembalian : Form
    {
        public Pengembalian()
        {
            InitializeComponent();
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

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-MKB157K; database= IniPerpus; User ID=sa; Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Peminjaman set Tgl_Kembali=@tgl_Kembali where Id_Peminjaman =@Id_Peminjaman", con);
            cmd.Parameters.AddWithValue("@Id_Peminjaman", txtID.Text);
            cmd.Parameters.AddWithValue("@Id_Anggota", txtAnggota.Text);
            cmd.Parameters.AddWithValue("@Id_Buku", txtIDBuku.Text);
            cmd.Parameters.AddWithValue("@tgl_Kembali", txtKembali.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sukses update data");
        }
    }
}
