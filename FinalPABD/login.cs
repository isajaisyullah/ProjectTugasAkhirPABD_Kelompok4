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
    public partial class login : Form
    {
        readonly string Username = "Admin";
        readonly string Password = "AdminPass";

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == Username && txtPassword.Text == Password)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap");
            }
            else
            {
                MessageBox.Show("username atau password salah!");
            }
        }
    }
}
