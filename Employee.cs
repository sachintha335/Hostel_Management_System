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
using System.Xml.Linq;

namespace Hostel_Management_System
{
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader mdr;
        public Employee()
        {
            InitializeComponent();
            DBConnection DBconnection = DBConnection.getConnection();
            con = DBconnection.con;
            con.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtMobile.Text != "" && txtName.Text != "" && txtEmpID.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtDesignation.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String id = txtEmpID.Text;
                String name = txtName.Text;
                String address = txtAddress.Text;
                String email = txtEmail.Text;
                String designation = txtDesignation.SelectedItem.ToString();
                con.Open();
                String query = "insert into EmployeeDetails(MobileNum,EmpID,EmpName,Address,Email,Designation) values('" + mobile + "','" + id + "','" + name + "','" + address + "','" + email + "','" + designation + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Employee successfully Added");
                con.Close();
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from EmployeeDetails Where MobileNum=" + txtMobile.Text + "", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtEmpID.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0][5].ToString();
                con.Close();

            }
            else
            {
                txtEmpID.Clear();
                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtDesignation.SelectedIndex = -1;
                MessageBox.Show("No Record Exit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update EmployeeDetails set EmpID='" + txtEmpID.Text + "', EmpName='" + txtName.Text + "',Address = '" + txtAddress.Text + "',Email = '" + txtEmail.Text + "',Designation='" + txtDesignation.Text + "' where MobileNum =" + txtMobile.Text + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updation Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            clearAll();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtMobile.Clear();
            txtEmpID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtDesignation.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete EmployeeDetails where MobileNum =" + txtMobile.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Data Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                clearAll();
            }
        }
    }
}
