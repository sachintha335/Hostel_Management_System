using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hostel_Management_System
{
    public partial class Student_Management : Form
    {
        String updateId = "";
        String connectionString;
        SqlConnection cnn;
        public Student_Management()
        {
            InitializeComponent();
            DBConnection DBconnection = DBConnection.getConnection();
            cnn = DBconnection.con;
            cnn.Close();
            cnn.Open();
            addItemToRoomCombo();
            createDeleteButtonColumn();
            createViewButtonColumn();
            

        }

        

        //Adding available room numbers to the combo box of the room selection in the form
        private void addItemToRoomCombo()
        {
            // SqlConnection cnn = dbConnect();
           
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
            
        }

        private void clearAll()
        {
            nameBox.Clear();
            mobileBox.Clear();
            studIdRichBox.Clear();
            yearBox.Clear();
            facultyBox.Clear();
            emailBox.Clear();
            parentContactBox.Clear();
            roomNoCombo.SelectedIndex = -1;

        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
           
            //SqlConnection cnn = dbConnect();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            

            //Assining the values to the variables from the fields
            String name=nameBox.Text;
            String mobile=mobileBox.Text;
            String studId= studIdRichBox.Text;
            int year=int.Parse(yearBox.Text); 
            String faculty=facultyBox.Text;
            String email=emailBox.Text;
            String parentNo=parentContactBox.Text;
            int roomNo = int.Parse(roomNoCombo.Text);
            sql = "Insert into Students(Name,Mobile_No,Student_Id,Year,Faculty,Email,Parent_No,Room_No) values('" + name + "','" + mobile+"','"+studId+"',"+year+",'"+faculty + "','" +email + "','" +parentNo + "'," +roomNo+")";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully!");

            command.Dispose();
            //cnn.Close();
            clearAll();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String searchKey=searchBox.Text;
           // cnn.Open();
            //SqlConnection cnn = dbConnect();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            String sql = "";

            sql = "Select Student_Id, Name From Students Where Lower(Student_Id) Like Lower('%"+searchKey+"%')";
            //sql = "Select Student_Id,Name From Students";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            //This creates a DataTable object and assing the values to the DataTable object from the dataReader
            DataTable table = new DataTable();
            table.Load(dataReader);
            dataGridView1.DataSource = table;//Assigning the DataTable object to the data Source of the datagridview
            //cnn.Close();
        }



        private void createDeleteButtonColumn()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);

        }

        private void createViewButtonColumn()
        {
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.HeaderText = "View";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(viewButtonColumn);

        }

        //dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cnn.Open();
            //MessageBox.Show("Button Works");
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //SqlConnection cnn = dbConnect();
                SqlCommand command;
                String deleteId = "";
                String sql = "";
                SqlDataAdapter adapter;
                deleteId = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                //MessageBox.Show(deleteId);

                // Show confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Perform the delete operation in the database
                    sql = "Delete from Students Where Student_Id='" + deleteId + "'";
                    command = new SqlCommand(sql, cnn);
                    adapter = new SqlDataAdapter();
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                   // cnn.Close();
                    MessageBox.Show("Record Deleted Successfully!");

                }    

            }

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
               // SqlConnection cnn = dbConnect();
                SqlCommand command;
                String sql = "";
                SqlDataAdapter adapter;
                updateId = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                //MessageBox.Show(deleteId);

                SqlDataReader dataReader;
                String sql1 = "";

                sql1 = "Select *From Students Where Student_Id='" + updateId + "'";

                command = new SqlCommand(sql1, cnn);
                dataReader = command.ExecuteReader();


                //Setting the values to the text fields of the correstponding record to be updated
                if (dataReader.Read())
                {
                    nameBox.Text = dataReader.GetString(0);
                    mobileBox.Text = dataReader.GetString(1);
                    studIdRichBox.Text = dataReader.GetString(2);
                    yearBox.Text = dataReader.GetInt32(3).ToString();
                    facultyBox.Text = dataReader.GetString(4);
                    emailBox.Text = dataReader.GetString(5);
                    parentContactBox.Text = dataReader.GetString(6);
                    roomNoCombo.Text = dataReader.GetInt32(7).ToString();
                    studIdRichBox.Text= dataReader.GetString(2);
                }

                updateBtn.Visible = true;
                saveBtn.Visible = false;
                addNewBtn.Visible = true;
                studIdRichBox.ReadOnly= true;//Making the primary key not editable in the update mode
                studIdRichBox.ForeColor = Color.Gray;//Changing the Color of the text to indicate that the field cannot be edited
                


            }



        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
           // cnn.Open();
            // SqlConnection cnn = dbConnect();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";


            //Assining the values to the variables from the fields
            String name = nameBox.Text;
            String mobile = mobileBox.Text;
            String studId = studIdRichBox.Text;
            int year = int.Parse(yearBox.Text);
            String faculty = facultyBox.Text;
            String email = emailBox.Text;
            String parentNo = parentContactBox.Text;
            int roomNo = int.Parse(roomNoCombo.Text);
            //sql = "Update Students set Name ='"+name + "',Mobile_No ='"+mobile + "',Student_Id ='" + studId + "',Year =" + year + ",Faculty ='" + faculty + "',Email ='" + email + "',Parent_No ='" + parentNo + "',Room_No =" + roomNo;
            sql = "Update Students set Name ='" + name + "',Mobile_No ='" + mobile + "',Year =" + year + ",Faculty ='" + faculty + "',Email ='" + email + "',Parent_No ='" + parentNo + "',Room_No =" + roomNo +"Where Student_Id='"+updateId+"'";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully!");

            command.Dispose();
           // cnn.Close();
            clearAll();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            clearAll();
            addNewBtn.Visible = false;
            saveBtn.Visible = true;
            updateBtn.Visible = false;
            studIdRichBox.ReadOnly = false;//Again making the primary key editable when switching from update mode to add new mode
            studIdRichBox.ForeColor = Color.Black;
        }

        private void addNewStudLbl_Click(object sender, EventArgs e)
        {

        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
