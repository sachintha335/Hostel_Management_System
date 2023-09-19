using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Student_Section_01 : Form
    {
        public Student_Section_01()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-428C8AM;Initial Catalog=HMS;Integrated Security=True";
            int studentIdToSearch = 111; // Replace with the student ID coming from login

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Students WHERE Student_Id = @studentId";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentIdToSearch);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nameL.Text = $"{reader["Name"]}";
                        mobileL.Text = $"{reader["Mobile_No"]}";
                        stuL.Text = $"{reader["Student_Id"]}";
                        yearL.Text = $"{reader["Year"]}";
                        facultyL.Text = $"{reader["Faculty"]}";
                        emailL.Text = $"{reader["Email"]}";
                        pcontactL.Text = $"{reader["Parent_No"]}";
                        roomL.Text = $"{reader["Room_No"]}";

                        byte[] imageData = reader["Profile"] as byte[];

                        if (imageData != null && imageData.Length > 0)
                        {
                            DisplayImage(imageData);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }

                    reader.Close();
                }

                connection.Close();
            }
        

        }

        void DisplayImage(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
                    }

        private void facultyL_Click(object sender, EventArgs e)
        {

        }

        private void stuL_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
