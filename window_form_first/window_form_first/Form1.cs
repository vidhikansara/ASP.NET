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

namespace window_form_first
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dt;
        SqlDataAdapter sdt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sdt = new SqlDataAdapter("select * from first", con);
            DataTable dtt = new DataTable();
            sdt.Fill(dtt);
            dataGridView1.DataSource = dtt;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mA016_1DataSet.first' table. You can move, or remove it, as needed.
            this.firstTableAdapter.Fill(this.mA016_1DataSet.first);
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MA016_1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into first values(" + textBox1.Text + ",'" + textBox2.Text+"')",con);
            int rec = cmd.ExecuteNonQuery();
            if(rec>0)
            {
                MessageBox.Show("Record Inserted !!");
            }
        }
    }
}
