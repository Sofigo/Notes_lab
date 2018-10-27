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
        private string userName;

        public FormLog()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bohachek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [tSetUser] where username = '" + textUser.Text + "' and password = '" + textPassword.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                userName = textUser.Text;
                this.Hide();
                Form1 ss = new Form1(userName);
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your username or password");

            }


        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
