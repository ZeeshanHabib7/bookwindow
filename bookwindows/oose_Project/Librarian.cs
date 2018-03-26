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
namespace oose_Project
{
    public partial class Librarian : Form
    {
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zeesh\OneDrive\Documents\LibrarySystem.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlConn = new SqlConnection(conn);
        public void connOpen()
        {
            sqlConn.Open();
        }
        public void connClose()
        {
            sqlConn.Close();
        }
        public Librarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryReg = "";
            if (radioButton1.Checked == true)
            {
                queryReg = "Insert into [Lib] (StudentID,ISBN,IssueDate,ReturnDate,Fine,LibID,status) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + radioButton1.Text + "');";


            }
            else if (radioButton2.Checked == true)
            {
                queryReg = "Insert into [LibRet] (StudentID,ISBN,IssueDate,ReturnDate,Fine,LibID,status) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + radioButton2.Text + "');";

            }
            /*else if (radioButton3.Checked == true)
            {
                queryReg = "Insert into [SignUp] (Name,Email, Password,Address,Phone,title) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "', '" + radioButton3.Text + "');";
            }
            */

            connOpen();
            SqlCommand cmdReg = new SqlCommand(queryReg, sqlConn);
            if (cmdReg.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Request Successfull");
                this.Close();
            }
            /* else if (textBox2.Text == textBox3.Text)
             {
                 label10.Text = "Confirm password success!";
             }
             */
            else
            {
                label7.Text = "Not Confirm!";
            }
            connClose();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l1 = new Login();
            l1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewReq vr = new ViewReq();
            vr.Show();
        }
    }
}
