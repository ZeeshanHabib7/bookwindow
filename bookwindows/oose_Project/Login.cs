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
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s1 = new SignUp();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connOpen();
            if (radioButton1.Checked == true)
            {
                string queryLog = "SELECT 1 FROM SignUp WHERE Email = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'and title = '" + radioButton1.Text + "' ;";
                SqlCommand cmd = new SqlCommand(queryLog, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    label5.Text = "Login Successfully";
                    Student sp = new Student();
                    this.Hide();
                    sp.Show();

                }
                else { 
                    label5.Text = "Wrong username,password or job!";
                }
            }
            else if (radioButton2.Checked == true)
            {
                string queryLog = "SELECT 1 FROM SignUp WHERE Email = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'and title = '" + radioButton2.Text + "' ;";
                SqlCommand cmd = new SqlCommand(queryLog, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    label5.Text = "Login Successfully";
                    Librarian lb = new Librarian();
                    this.Hide();
                    lb.Show();
                }
                else {   //                MessageBox.Show("Login Error");
                    label5.Text = "Wrong username,password or job!";
                }
            }
            else if (radioButton3.Checked == true)
            {
                string queryLog = "SELECT 1 FROM SignUp WHERE Email = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'and title = '" + radioButton3.Text + "' ;";
                SqlCommand cmd = new SqlCommand(queryLog, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    label5.Text = "Login Successfully";
                   Admin an = new Admin();
                    this.Hide();
                    an.Show();
                }
                else {   //                MessageBox.Show("Login Error");
                    label5.Text = "Wrong username,password or job!";
                }
            }

            connClose();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
