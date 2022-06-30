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
    public partial class tambahBuku : Form
    {
        public tambahBuku()
        {
            InitializeComponent();
            txtID.Text = txtID.Text;
            txtJudul.Text = txtJudul.Text;
            txtKategori.Text = txtKategori.Text;
            txtLetak.Text = txtLetak.Text;
            txtPenerbit.Text = txtPenerbit.Text;
            txtPenulis.Text = txtPenulis.Text;
            txtTahun.Text = txtTahun.Text;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-MKB157K; database= IniPerpus; User ID=sa; Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Buku values (@Id_Buku, @Judul, @Penulis, @Penerbit, " +
                "@Tahun, @Kategori, @Id_Rak)", con);
            cmd.Parameters.AddWithValue("@Id_Buku", txtID.Text);
            cmd.Parameters.AddWithValue("@Judul", txtJudul.Text);
            cmd.Parameters.AddWithValue("@Penulis", txtPenulis.Text);
            cmd.Parameters.AddWithValue("@Penerbit", txtPenerbit.Text);
            cmd.Parameters.AddWithValue("@Tahun", txtTahun.Text);
            cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
            cmd.Parameters.AddWithValue("@Id_Rak", txtLetak.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sukses simpan data");
            txtID.Clear();
            txtJudul.Clear();
            txtKategori.Clear();
            txtLetak.Clear();
            txtPenerbit.Clear();
            txtPenulis.Clear();
            txtTahun.Clear();
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

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
