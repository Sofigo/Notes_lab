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

namespace Notes
{
    public partial class FormNotes : Form
    {
        DataTable table;

        public FormNotes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 140;

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source:\Notes\Notes\Database2.mdf;");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Database1 where username = '" + textMessage.Text + "' and password = '" + textTitle.Text + "'", sqlcon);
            textTitle.Clear();
            textMessage.Clear();
            table.Rows.Add(textTitle.Text, textMessage.Text);
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLog dd = new FormLog();
            dd.Show();
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database2DataSet.Table);

        }
    }
}
