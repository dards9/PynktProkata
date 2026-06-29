using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        OleDbConnection con = new OleDbConnection(
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;");

        const string ADMIN_CODE = "123";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtLogin1.Text.Trim() == "" ||
       txtPassword2.Text.Trim() == "" ||
       txtPassword3.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            if (txtPassword2.Text != txtPassword3.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            try
            {
                con.Open();

                // Проверяем, существует ли пользователь
                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM Users WHERE Login=?", con);

                check.Parameters.AddWithValue("@p1", txtLogin1.Text);

                int count = Convert.ToInt32(check.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Такой пользователь уже существует.");
                    con.Close();
                    return;
                }

                string role = "User";

                if (txtAdminCode.Text == ADMIN_CODE)
                {
                    role = "Admin";
                }
                else if (txtAdminCode.Text != "")
                {
                    MessageBox.Show("Неверный код администратора.");
                    con.Close();
                    return;
                }

                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Users ([Login], [Password], [Role]) VALUES (?, ?, ?)", con);

                cmd.Parameters.AddWithValue("@p1", txtLogin1.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword2.Text);
                cmd.Parameters.AddWithValue("@p3", role);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Пользователь успешно зарегистрирован.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
