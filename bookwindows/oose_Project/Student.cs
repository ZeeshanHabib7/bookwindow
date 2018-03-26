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
    
    public partial class Student : Form
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
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryReg = "";
            if (radioButton1.Checked == true)
            {
                queryReg = "Insert into [BookReq] (AuthorName,BookTitle,Edition,StudentID,status,requestdate) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + radioButton1.Text + "', '" + dateTimePicker1.Text + "');";

                dateTimePicker1.Enabled = true;


            }
            else if (radioButton2.Checked == true)
            {
                queryReg = "Insert into [BookRet] (AuthorName,BookTitle,Edition,StudentID,status,returndata) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + radioButton2.Text + "', '" + dateTimePicker2.Text + "');";
                dateTimePicker2.Enabled = true;


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
                label5.Text = "Not Confirm!";
            }
            connClose();
            this.Close();
            Login l1 = new Login();
            l1.Show();


        }

        private void Student_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            connOpen();
            string que = "select Author from Admin;";
            SqlCommand cmd = new SqlCommand(que, sqlConn);
            IDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);

            }
            connClose();

            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            //groupBox2.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            connOpen();

            string que1 = "select BookName from Admin;";
            SqlCommand cmd1 = new SqlCommand(que1, sqlConn);
            IDataReader dataReader1 = cmd1.ExecuteReader();
            while (dataReader1.Read())
            {
                comboBox2.Items.Add(dataReader1[0]);

            }

            connClose();

        }
    }
}
