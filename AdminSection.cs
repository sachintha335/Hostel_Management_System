using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class frmAdminSection : Form
    {
        public frmAdminSection()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserLogin newLogin = new frmUserLogin();
            newLogin.Show();
            this.Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Student_Management newStudent = new Student_Management() { TopLevel = false, TopMost = true};
            newStudent.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newStudent);
            newStudent.Show();

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee() { TopLevel = false, TopMost = true };
            newEmployee.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newEmployee);
            newEmployee.Show();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            complaint newComplaint = new complaint() { TopLevel = false, TopMost = true };
            newComplaint.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newComplaint);
            newComplaint.Show();
        }
    }
}
