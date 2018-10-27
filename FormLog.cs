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
using System.Security;

namespace Notes
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source:\Notes\Notes\Database1.mdf;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Database1 where username = '" + textUser.Text + "' and password = '" + textPassword.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Please check your username or password");

            }
            else
            {
                this.Hide();
                FormNotes ss = new FormNotes();
                ss.Show();
            }


        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
