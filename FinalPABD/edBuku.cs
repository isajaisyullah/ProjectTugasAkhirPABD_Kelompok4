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
    public partial class edBuku : Form
    {
        DataRow dr;
        string code;

        public edBuku()
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

        private void edBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.iniPerpusDataSet.Buku);

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            code = txtID.Text;

            dr = iniPerpusDataSet.Tables["Buku"].Rows.Find(code);
            dr.Delete();

            bukuTableAdapter.Update(iniPerpusDataSet);
            MessageBox.Show("Sukses hapus data");


        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source = DESKTOP-MKB157K; database= IniPerpus; User ID=sa; Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Buku set Judul=@Judul, Penulis=@Penulis, Penerbit=@Penerbit, Tahun=@Tahun, Karegori=@Kategori, Id_Rak = @Id_Rak  where Id_Buku =@Id_Buku", con);
            cmd.Parameters.AddWithValue("@Id_Buku", txtID.Text);
            cmd.Parameters.AddWithValue("@Judul", txtJudul.Text);
            cmd.Parameters.AddWithValue("@Penulis", txtPenulis.Text);
            cmd.Parameters.AddWithValue("@Penerbit", txtPenerbit.Text);
            cmd.Parameters.AddWithValue("@Tahun", txtTahun.Text);
            cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
            cmd.Parameters.AddWithValue("@Id_Rak", txtLetak.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sukses update data");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
