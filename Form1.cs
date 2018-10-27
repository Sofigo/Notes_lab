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
    public partial class Form1 : Form
    {
        DataTable table;
        public string userName;
        SqlConnection sqlcon;
        SqlDataAdapter sda;

        public Form1(string userName)
        {
            InitializeComponent();
            
            this.userName = userName;
        

            this.sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bohachek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");

            table = new DataTable();
            table.Columns.Add("TitleCol", typeof(String));
            table.Columns.Add("NoteCol", typeof(String));


            sda = new SqlDataAdapter("Select title TitleCol, noteText NoteCol From [tSetNotes] where username = '" + userName + "'", sqlcon);

            sda.Fill(table);


            dataGridView1.DataSource = table;
            //    dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["TitleCol"].Width = 140;

            sda = new SqlDataAdapter();

            sqlcon.Open();
        }

        private void ADD_Click(object sender, EventArgs e)
        {

            sda.InsertCommand = new SqlCommand("INSERT INTO [tSetNotes] (username, title, noteText, creationDate) values( '" + userName.ToString() + "', '" + textTitle.Text + "', '" + textNote.Text + "', cast('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' as DATETIME))", sqlcon);
            table.Rows.Add(textTitle.Text, textNote.Text);
            sda.InsertCommand.ExecuteNonQuery();
            textTitle.Clear();
            textNote.Clear();
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;


            sda.DeleteCommand = new SqlCommand("DELETE FROM [tSetNotes] where username =  '" + userName.ToString() + "' and title = '" + table.Rows[index][0].ToString() + "'", sqlcon);
            
            MessageBox.Show("DELETE FROM [tSetNotes] where username =  '" + userName.ToString() + "' and title = '" + table.Rows[index][0].ToString() + "'");
            table.Rows[index].Delete();

        }
        private void EDIT_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            MessageBox.Show(table.Rows[index][0].ToString());

            //     sda.DeleteCommand = new SqlCommand("DELETE FROM [tSetNotes] where username =  '" + userName + "' and title = '" table.Rows[index].", sqlcon);
            //   table.Rows[index].Delete();

        }


        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLog dd = new FormLog();
            dd.Show();
        }
        
    }
}
