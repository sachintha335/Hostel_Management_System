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
    public partial class frmManageRooms : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String query;
        public frmManageRooms()
        {
            InitializeComponent();
            DBConnection DBconnection = DBConnection.getConnection();
            connection = DBconnection.con; 
            displayData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = "insert into Room values(@capacity, @availability)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@capacity", int.Parse(txtCapacity.Text));
            bool availability;
            if (cmbAvailability.Text == "Yes")
                availability = true;
            else
                availability = false;
            command.Parameters.AddWithValue("@availability", availability);
            
            command.ExecuteNonQuery();
            MessageBox.Show("Room data is sucessfully inserted", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            clear();
            displayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = "update Room set Capacity = @capacity, Availability = @availability where RoomNo = @roomNo";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@roomNo", int.Parse(txtRoomNo.Text));
            command.Parameters.AddWithValue("@capacity", int.Parse(txtCapacity.Text));
            bool availability;
            if (cmbAvailability.Text == "Yes")
                availability = true;
            else
                availability = false;
            command.Parameters.AddWithValue("@availability", availability);
            command.ExecuteNonQuery();
            MessageBox.Show("Data is successfully updated", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            clear();
            displayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this data ?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                query = "delete Room where RoomNo = @roomNo";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomNo", int.Parse(txtRoomNo.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Data is successfully deleted", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                displayData();
            }
            else
            {
                clear();
            }
            connection.Close();
            
        }

        public void displayData()
        {
            connection.Open();
            query = "select * from Room";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        public void clear()
        {
            txtRoomNo.Clear();
            txtCapacity.Clear();
            cmbAvailability.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
