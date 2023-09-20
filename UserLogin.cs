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
    public partial class frmUserLogin : Form
    {
        string query;
        SqlCommand command;
        SqlConnection connection;
        public frmUserLogin()
        {
            InitializeComponent();
            DBConnection DBconnection = DBConnection.getConnection();
            connection = DBconnection.con;
        }

        public void clear()
        {
            cmbRole.Text = "";
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            query = "select * from UserLogin where role = @role and userName = @userName and password = @password";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@role",cmbRole.Text);
            command.Parameters.AddWithValue("@userName", txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (cmbRole.Text == "Admin")
                { 
                    frmAdminSection newAdmin = new frmAdminSection();
                    newAdmin.Show();
                    this.Hide();
                }
                else if (cmbRole.Text == "Student")
                {
                    StudentSection newStudent = new StudentSection();
                    newStudent.Show();
                    this.Hide();
                }
                    
            }
            else
            {
                MessageBox.Show("Incorrect Credentials !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
                

        }
    }
}
