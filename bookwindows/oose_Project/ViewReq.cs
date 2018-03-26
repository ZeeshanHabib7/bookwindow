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
    public partial class ViewReq : Form
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

        public ViewReq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BookREqTableAdapter.Fill(this.LibrarySystemDataSet.BookREq);

            this.reportViewer1.RefreshReport();

            /*string queryview = "Select * from BookReq ;";
            connOpen();
            SqlCommand cmdview = new SqlCommand(queryview, sqlConn);
            cmdview.ExecuteNonQuery();
            //MessageBox.Show("Insert Successfully!");
            DataTable dt = new DataTable();
            SqlDataAdapter db = new SqlDataAdapter(cmdview);
            db.Fill(dt);
            dataGridView1.DataSource = dt;

            connClose();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryview = "Select * from BookRet ;";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewReq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibrarySystemDataSet.BookREq' table. You can move, or remove it, as needed.
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
