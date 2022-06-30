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
    public partial class edAnggota : Form
    {
        DataRow dr;
        string code;
        public edAnggota()
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

        private void button7_Click(object sender, EventArgs e)
        {
            new Pengembalian().Show();
            this.Hide();
        }

        private void edAnggota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iniPerpusDataSet.Anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.iniPerpusDataSet.Anggota);

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-MKB157K; database= IniPerpus; User ID=sa; Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Anggota set Nama=@Nama, JKelamin=@JKelamin, noTelp=@noTelp, Alamat=@Alamat where Id_Anggota =@Id_Anggota", con);
            cmd.Parameters.AddWithValue("@Id_Anggota", txtID.Text);
            cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@JKelamin", txtJK.Text);
            cmd.Parameters.AddWithValue("@noTelp", txtTelpon.Text);
            cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Sukses update data");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            code = txtID.Text;

            dr = iniPerpusDataSet.Tables["Anggota"].Rows.Find(code);
            dr.Delete();

            anggotaTableAdapter.Update(iniPerpusDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
