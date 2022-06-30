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
    public partial class tmAnggota : Form
    {
        public tmAnggota()
        {
            InitializeComponent();
            txtID.Text = txtID.Text;
            txtNama.Text = txtNama.Text;
            txtJK.Text = txtJK.Text;
            txtTelpon.Text = txtTelpon.Text;
            txtAlamat.Text = txtAlamat.Text;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DataBuku().Show();
            this.Hide();  
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new dtAnggota().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new dtPeminjaman().Show();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-MKB157K; database= IniPerpus; User ID=sa; Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Anggota values (@Id_Anggota, @Nama, @JKelamin, @noTelp, @Alamat)", con);
            cmd.Parameters.AddWithValue("@Id_Anggota", txtID.Text);
            cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@JKelamin", txtJK.Text);
            cmd.Parameters.AddWithValue("@noTelp", txtTelpon.Text);
            cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sukses simpan data");

            txtID.Clear();
            txtNama.Clear();
            txtJK.Clear();
            txtTelpon.Clear();
            txtAlamat.Clear();
        }
    }
}
