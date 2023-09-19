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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hostel_Management_System
{
    public partial class Student_Management : Form
    {
        public Student_Management()
        {
            InitializeComponent();
            addItemToRoomCombo();
        }

        public SqlConnection dbConnect()
        {
            String connectionString;
            SqlConnection cnn;//https://www.mytecbits.com/microsoft/dot-net/error-sqlconnection-could-not-be-found
            connectionString = "Data Source=DESKTOP-428C8AM;Initial Catalog=HMS;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            return cnn;
        }

        //Adding available room numbers to the combo box of the room selection in the form
        private void addItemToRoomCombo()
        {
            SqlConnection cnn = dbConnect();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "Select RoomNo from Room where Availability=1";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                roomNoCombo.Items.Add(dataReader["RoomNo"].ToString());
            }

            dataReader.Close(); 
            command.Dispose();
            cnn.Close();
        }

        private void clearAll()
        {
            nameBox.Clear();
            mobileBox.Clear();
            studentIdBox.Clear();
            yearBox.Clear();
            facultyBox.Clear();
            emailBox.Clear();
            parentContactBox.Clear();
            roomNoCombo.SelectedIndex = -1;

        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = dbConnect();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            

            //Assining the values to the variables from the fields
            String name=nameBox.Text;
            String mobile=mobileBox.Text;
            String studId=studentIdBox.Text;
            int year=int.Parse(yearBox.Text); 
            String faculty=facultyBox.Text;
            String email=emailBox.Text;
            String parentNo=parentContactBox.Text;
            int roomNo = int.Parse(roomNoCombo.Text);
            sql = "Insert into Students(Name,Mobile_No,Student_Id,Year,Faculty,Email,Parent_No,Room_No) values('" + name + "','" + mobile+"','"+studId+"',"+year+",'"+faculty + "','" +email + "','" +parentNo + "'," +roomNo+")";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

           
            command.Dispose();
            cnn.Close();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void addNewStudLbl_Click(object sender, EventArgs e)
        {

        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
