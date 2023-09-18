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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hostel_Management_System
{
    public partial class Form2 : Form
    {
        SqlCommand command;
        String sql;
        public Form2()
        {
            InitializeComponent();
            textBox5.Multiline = true;
            textBox5.ScrollBars = ScrollBars.Both;
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

            sql = "insert into Details values('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"','"+textBox5.Text+"')";


            command = new SqlCommand(sql, conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //comboBox1.Items.Clear();
            textBox5.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdmin admin = new frmAdmin();
            admin.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn;
            conn = connectdb();
            String searchValue= textBox6.Text;
            String sqlRe;
            sqlRe = "select * from Details where Student_no= @searchValue";

            SqlDataAdapter sql1 = new SqlDataAdapter(sqlRe, conn);
            sql1.SelectCommand.Parameters.AddWithValue("@searchValue", searchValue);

            DataTable dtb1 = new DataTable();
            sql1.Fill(dtb1);

            dataGridView1.DataSource = dtb1;

            conn.Close();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
