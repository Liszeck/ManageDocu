using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDocu
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Model model = new Model();
                    View view = new View();
                    Presenter presenter = new Presenter(model, view);
                    view.ShowDialog();
                    cn.Close();
                    this.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

