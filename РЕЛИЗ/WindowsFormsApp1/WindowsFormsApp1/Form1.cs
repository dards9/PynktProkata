using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string userRole;
        public Form1(string role)
        {
            InitializeComponent();

            userRole = role;
        }

        OleDbConnection con =
new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;");

        OleDbDataAdapter adapter;

        DataTable table;
        DataTable tableData;

        string currentTable = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(table.NewRow());
        }
        private void LoadTable(string tableName)
        {
            try
            {
                currentTable = tableName;

                table = new DataTable();

                adapter = new OleDbDataAdapter(
                    "SELECT * FROM [" + tableName + "]", con);

                OleDbCommandBuilder builder =
                    new OleDbCommandBuilder(adapter);

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OpenTable(string table)
        {
            try
            {
                currentTable = table;

                tableData = new DataTable();

                adapter = new OleDbDataAdapter(
                    "SELECT * FROM [" + table + "]", con);

                OleDbCommandBuilder builder =
                    new OleDbCommandBuilder(adapter);

                adapter.Fill(tableData);

                dataGridView1.DataSource = tableData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ibiRole.Text = "Пользователь: " + userRole;
            OpenTable("Клиенты");

            if (userRole == "User")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;

                dataGridView1.ReadOnly = true;
                tabControl1.TabPages.Remove(tabPage5);
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommandBuilder builder =
                    new OleDbCommandBuilder(adapter);

                adapter.Update(table);

                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTable(currentTable);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    OpenTable("Аренда");
                    break;

                case 1:
                    OpenTable("Категории");
                    break;

                case 2:
                    OpenTable("Клиенты");
                    break;

                case 4:
                    OpenTable("Users");
                    break;
                case 3:
                    OpenTable("Оборудование");
                    break;
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tableData.DefaultView;

                string filter = "";

                foreach (DataColumn col in tableData.Columns)
                {
                    if (filter != "")
                        filter += " OR ";

                    filter += "[" + col.ColumnName + "] LIKE '%" +
                              txtSearch.Text.Replace("'", "''") + "%'";
                }

                dv.RowFilter = filter;

                dataGridView1.DataSource = dv;
            }
            catch
            {
                MessageBox.Show("Ошибка поиска");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();

            login.Show();

            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                bool visible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        visible = true;
                        break;
                    }
                }

                row.Visible = visible;
            }

            cm.ResumeBinding();
        }
    }
}
