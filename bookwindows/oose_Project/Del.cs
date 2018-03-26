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
    public partial class Del : Form
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

        public Del()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryDel = "DELETE from [Admin] where ISBN = '" + textBox1.Text + "'";
            connOpen();
            SqlCommand cmdDel = new SqlCommand(queryDel, sqlConn);
            if (cmdDel.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Book Remove Successfully!");
            }
            connClose();
            this.Close();
        }
    }
}
