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
    public partial class Admin : Form
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

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Del d = new Del();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Update_button.Enabled = true;
            string queryview = "Select * from Admin;";
            connOpen();
            SqlCommand cmdview = new SqlCommand(queryview, sqlConn);
            cmdview.ExecuteNonQuery();
            //MessageBox.Show("Insert Successfully!");
            DataTable dt = new DataTable();
            SqlDataAdapter db = new SqlDataAdapter(cmdview);
            db.Fill(dt);
            dataGridView1.DataSource = dt;

            connClose();
        }
    }
}
