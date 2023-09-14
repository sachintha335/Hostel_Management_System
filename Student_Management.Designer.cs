namespace Hostel_Management_System
{
    partial class Student_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.parentContactBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.searchStudLbl = new System.Windows.Forms.Label();
            this.addNewStudLbl = new System.Windows.Forms.Label();
            this.headingLbl = new System.Windows.Forms.Label();
            this.roomNoCombo = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Teal;
            this.backgroundPanel.Controls.Add(this.searchBtn);
            this.backgroundPanel.Controls.Add(this.roomNoCombo);
            this.backgroundPanel.Controls.Add(this.searchBox);
            this.backgroundPanel.Controls.Add(this.dataGridView1);
            this.backgroundPanel.Controls.Add(this.clearBtn);
            this.backgroundPanel.Controls.Add(this.saveBtn);
            this.backgroundPanel.Controls.Add(this.parentContactBox);
            this.backgroundPanel.Controls.Add(this.emailBox);
            this.backgroundPanel.Controls.Add(this.facultyBox);
            this.backgroundPanel.Controls.Add(this.yearBox);
            this.backgroundPanel.Controls.Add(this.studentIdBox);
            this.backgroundPanel.Controls.Add(this.mobileBox);
            this.backgroundPanel.Controls.Add(this.nameBox);
            this.backgroundPanel.Controls.Add(this.label7);
            this.backgroundPanel.Controls.Add(this.label6);
            this.backgroundPanel.Controls.Add(this.label5);
            this.backgroundPanel.Controls.Add(this.label4);
            this.backgroundPanel.Controls.Add(this.label3);
            this.backgroundPanel.Controls.Add(this.label2);
            this.backgroundPanel.Controls.Add(this.label1);
            this.backgroundPanel.Controls.Add(this.nameLbl);
            this.backgroundPanel.Controls.Add(this.searchStudLbl);
            this.backgroundPanel.Controls.Add(this.addNewStudLbl);
            this.backgroundPanel.Controls.Add(this.headingLbl);
            this.backgroundPanel.Location = new System.Drawing.Point(-1, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1057, 651);
            this.backgroundPanel.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(610, 153);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(239, 30);
            this.searchBox.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Name,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(610, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student Id";
            this.Student_ID.MinimumWidth = 6;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(424, 603);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(98, 34);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(283, 603);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 34);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // parentContactBox
            // 
            this.parentContactBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentContactBox.Location = new System.Drawing.Point(283, 494);
            this.parentContactBox.Name = "parentContactBox";
            this.parentContactBox.Size = new System.Drawing.Size(239, 30);
            this.parentContactBox.TabIndex = 17;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(283, 436);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(239, 30);
            this.emailBox.TabIndex = 16;
            // 
            // facultyBox
            // 
            this.facultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyBox.Location = new System.Drawing.Point(283, 381);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(239, 30);
            this.facultyBox.TabIndex = 15;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(283, 323);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(239, 30);
            this.yearBox.TabIndex = 14;
            // 
            // studentIdBox
            // 
            this.studentIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdBox.Location = new System.Drawing.Point(283, 269);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(239, 30);
            this.studentIdBox.TabIndex = 13;
            // 
            // mobileBox
            // 
            this.mobileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileBox.Location = new System.Drawing.Point(283, 213);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(239, 30);
            this.mobileBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(283, 153);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(239, 30);
            this.nameBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Room No.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Parent\'s Contact No.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Faculty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mobile No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(13, 153);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(211, 30);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchStudLbl
            // 
            this.searchStudLbl.Font = new System.Drawing.Font("Doppio One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudLbl.ForeColor = System.Drawing.Color.White;
            this.searchStudLbl.Location = new System.Drawing.Point(678, 68);
            this.searchStudLbl.Name = "searchStudLbl";
            this.searchStudLbl.Size = new System.Drawing.Size(348, 42);
            this.searchStudLbl.TabIndex = 2;
            this.searchStudLbl.Text = "Search Student";
            this.searchStudLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewStudLbl
            // 
            this.addNewStudLbl.Font = new System.Drawing.Font("Doppio One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudLbl.ForeColor = System.Drawing.Color.White;
            this.addNewStudLbl.Location = new System.Drawing.Point(35, 68);
            this.addNewStudLbl.Name = "addNewStudLbl";
            this.addNewStudLbl.Size = new System.Drawing.Size(348, 42);
            this.addNewStudLbl.TabIndex = 1;
            this.addNewStudLbl.Text = "Add New Student";
            this.addNewStudLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headingLbl
            // 
            this.headingLbl.Font = new System.Drawing.Font("Doppio One", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.ForeColor = System.Drawing.Color.White;
            this.headingLbl.Location = new System.Drawing.Point(323, 0);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(385, 59);
            this.headingLbl.TabIndex = 0;
            this.headingLbl.Text = "Student Management";
            this.headingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNoCombo
            // 
            this.roomNoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoCombo.FormattingEnabled = true;
            this.roomNoCombo.Location = new System.Drawing.Point(283, 550);
            this.roomNoCombo.Name = "roomNoCombo";
            this.roomNoCombo.Size = new System.Drawing.Size(239, 33);
            this.roomNoCombo.TabIndex = 23;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(900, 153);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 29);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 649);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Student_Management";
            this.Text = "Student_Management";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label searchStudLbl;
        private System.Windows.Forms.Label addNewStudLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parentContactBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.ComboBox roomNoCombo;
        private System.Windows.Forms.Button searchBtn;
    }
}