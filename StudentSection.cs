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
    public partial class StudentSection : Form
    {
        public StudentSection()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Student_Section_01 newStudent = new Student_Section_01() { TopLevel = false, TopMost = true };
            newStudent.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newStudent);
            newStudent.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserLogin newLogin = new frmUserLogin();
            newLogin.Show();
            this.Hide();
        }
    }
}
