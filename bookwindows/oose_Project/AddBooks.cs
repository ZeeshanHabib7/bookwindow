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
    public partial class AddBooks : Form
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

        public AddBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryReg = "Insert into [Admin] (AdminID,BookName,ISBN,Author,Publication) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '"+ textBox5.Text + "');";
            connOpen();
            SqlCommand cmdReg = new SqlCommand(queryReg, sqlConn);
            if (cmdReg.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insert Successfully!\nADD more Books!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                //label8.Text = "Data Inserted";
            }
            connClose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}
