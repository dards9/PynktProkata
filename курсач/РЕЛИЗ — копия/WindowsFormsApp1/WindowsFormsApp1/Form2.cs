using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source=db.accdb;");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();

            reg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = new OleDbCommand(
            "SELECT Role FROM Users WHERE Login=? AND Password=?",
            con);

            cmd.Parameters.AddWithValue("@Login", txtLogin.Text);

            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            object role = cmd.ExecuteScalar();

            con.Close();

            if (role != null)
            {
                Form1 frm = new Form1(role.ToString());

                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
