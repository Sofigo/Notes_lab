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
        String editIndex;

        public Form1(string userName)
        {
            InitializeComponent();
            endEdit.Visible = false;
            this.userName = userName;
        

            this.sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bohachek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");

            table = new DataTable();
            table.Columns.Add("TitleCol", typeof(String));
            table.Columns.Add("NoteCol", typeof(String));


            sda = new SqlDataAdapter("Select id Id, title TitleCol, noteText NoteCol From [tSetNotes] where username = '" + userName + "'", sqlcon);

            sda.Fill(table);
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TitleCol"].Width = 140;
            dataGridView1.Columns["NoteCol"].Width = 370;

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
            String index = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            sda.DeleteCommand = new SqlCommand("DELETE FROM [tSetNotes] where Id = cast('" + index + "' as int)", sqlcon);
            try {
                sda.DeleteCommand.ExecuteNonQuery();
                table.Rows.Find(index).Delete();
            }
            catch (Exception)
            {
                MessageBox.Show( "An error occured");
            }

        }
        private void EDIT_Click(object sender, EventArgs e)
        {
            editIndex = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textTitle.Text = table.Rows.Find(editIndex)[0].ToString();
            textNote.Text = table.Rows.Find(editIndex)[1].ToString();

            endEdit.Visible = true;

        }


        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLog dd = new FormLog();
            dd.Show();
        }

        private void endEdit_Click(object sender, EventArgs e)
        {

            sda.UpdateCommand = new SqlCommand("UPDATE [tSetNotes] set title =  '" + textTitle.Text + "' , noteText = '" + textNote.Text + "' where Id =  cast('" + editIndex + "' as int)", sqlcon);

           try {
                sda.UpdateCommand.ExecuteNonQuery();

                table.Rows.Find(editIndex)[0] = textTitle.Text;
                table.Rows.Find(editIndex)[1] = textNote.Text;

                textTitle.Clear();
                textNote.Clear();
                endEdit.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Too long expression was typed ");
            }

        }
    }
}
