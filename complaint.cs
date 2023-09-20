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

namespace Hostel_Management_System
{
    public partial class complaint : Form
    {
        string query;
        SqlCommand command;
        SqlConnection conn;
        public complaint()
        {
            InitializeComponent();
            textBox5.Multiline = true;
            textBox5.ScrollBars = ScrollBars.Both;
            DBConnection DBconnection = DBConnection.getConnection();
            conn = DBconnection.con;
            conn.Close();
            
        }
       /* public SqlConnection connectdb()
        {
            string connectionString;
            SqlConnection conn;
            connectionString = @"Data Source=LAPTOP-21I8K0UF\MSSQLSERVER01;Initial Catalog=Complaint;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn.Open();

            return conn;
        }*/
        private bool validateNotEmpty(String textBox, String fieldName)
        {
            if (String.IsNullOrEmpty(textBox))
            {
                MessageBox.Show($"Please enter the {fieldName}");
                return false;

            }
            return true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //SqlConnection conn;
            //conn = connectdb();
            conn.Open();
            if (!validateNotEmpty(textBox1.Text, "Student Name")) return;
            if (!validateNotEmpty(textBox2.Text, "Student Number")) return;
            if (!validateNotEmpty(textBox3.Text, "Faculty")) return;
            if (!validateNotEmpty(textBox3.Text, "Level")) return;
            if (!validateNotEmpty(textBox3.Text, "Complaint")) return;
            /*
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the Student Name.");
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter the Student number.");
                return;
            }


            if(string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter the Faculty.");
                return;
            }
            if (!int.TryParse(textBox4.Text, out int intValue) || intValue < 0 || intValue > 5)
            {
                MessageBox.Show("Please enter an integer between 0 and 4.");
                return;
            }
           
            if(string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter the complaint.");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please enter the Faculty.");
                return;
            }
*/
            String sql;
            sql = "insert into Details values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')";
           

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //comboBox1.Items.Clear();
            textBox5.Clear();
            MessageBox.Show("insert successfully");



            String sql1;
            sql1 = "select *from Details";

            SqlDataAdapter sqlDa = new SqlDataAdapter(sql1, conn);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            dataGridView1.DataSource = dtb1;

            conn.Close();



        

         }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //comboBox1.Items.Clear();
            textBox5.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection conn;
            //conn = connectdb();
            conn.Open();
            String searchValue = textBox6.Text;
            String sqlRe;
            sqlRe = "select * from Details where Student_no= @searchValue";

            SqlDataAdapter sql1 = new SqlDataAdapter(sqlRe, conn);
            sql1.SelectCommand.Parameters.AddWithValue("@searchValue", searchValue);

            DataTable dtb1 = new DataTable();
            sql1.Fill(dtb1);

            dataGridView1.DataSource = dtb1;

            conn.Close();

        }
    }
}
