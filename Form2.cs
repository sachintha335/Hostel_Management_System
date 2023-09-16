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

namespace Hostel_Management_System
{
    public partial class Form2 : Form
    {
        SqlCommand command;
        String sql;
        public Form2()
        {
            InitializeComponent();
        }
        public SqlConnection connectdb()
        {
            string connectionString;
            SqlConnection conn;
            connectionString = @"Data Source=LAPTOP-21I8K0UF\MSSQLSERVER01;Initial Catalog=Complaint;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn.Open();

            return conn;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
              }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = connectdb();

            sql = "insert into Details values('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"','"+textBox5.Text+"')";


            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("insert successfully");
            conn.Close();

        }
    }
}
