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
    public partial class Canteen_Section : Form
    {
        public Canteen_Section()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserLogin newLogin = new frmUserLogin();
            newLogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canteen_Section_Add_Items newItem = new Canteen_Section_Add_Items() { TopLevel = false, TopMost = true };
            newItem.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newItem);
            newItem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Canteen_Section_Remove_Items deletedItem = new Canteen_Section_Remove_Items() { TopLevel = false, TopMost = true };
            deletedItem.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(deletedItem);
            deletedItem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Canteen_Section_View_Menu newMenu = new Canteen_Section_View_Menu() { TopLevel = false, TopMost = true };
            newMenu.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(newMenu);
            newMenu.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
