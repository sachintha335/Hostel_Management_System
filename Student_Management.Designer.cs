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
            this.studIdRichBox = new System.Windows.Forms.RichTextBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.roomNoCombo = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.parentContactBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
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
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Teal;
            this.backgroundPanel.Controls.Add(this.studIdRichBox);
            this.backgroundPanel.Controls.Add(this.addNewBtn);
            this.backgroundPanel.Controls.Add(this.updateBtn);
            this.backgroundPanel.Controls.Add(this.dataGridView1);
            this.backgroundPanel.Controls.Add(this.searchBtn);
            this.backgroundPanel.Controls.Add(this.roomNoCombo);
            this.backgroundPanel.Controls.Add(this.searchBox);
            this.backgroundPanel.Controls.Add(this.clearBtn);
            this.backgroundPanel.Controls.Add(this.saveBtn);
            this.backgroundPanel.Controls.Add(this.parentContactBox);
            this.backgroundPanel.Controls.Add(this.emailBox);
            this.backgroundPanel.Controls.Add(this.facultyBox);
            this.backgroundPanel.Controls.Add(this.yearBox);
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
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1315, 649);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // studIdRichBox
            // 
            this.studIdRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studIdRichBox.Location = new System.Drawing.Point(283, 269);
            this.studIdRichBox.Name = "studIdRichBox";
            this.studIdRichBox.Size = new System.Drawing.Size(239, 30);
            this.studIdRichBox.TabIndex = 28;
            this.studIdRichBox.Text = "";
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(18, 603);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(100, 34);
            this.addNewBtn.TabIndex = 27;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Visible = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(422, 603);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 34);
            this.updateBtn.TabIndex = 26;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(589, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 207);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Id";
            this.Column1.HeaderText = "Student_Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(888, 153);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 29);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(589, 152);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(239, 30);
            this.searchBox.TabIndex = 22;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(285, 603);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(98, 34);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(148, 603);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 34);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.searchStudLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudLbl.ForeColor = System.Drawing.Color.White;
            this.searchStudLbl.Location = new System.Drawing.Point(712, 68);
            this.searchStudLbl.Name = "searchStudLbl";
            this.searchStudLbl.Size = new System.Drawing.Size(348, 42);
            this.searchStudLbl.TabIndex = 2;
            this.searchStudLbl.Text = "Search Student";
            this.searchStudLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewStudLbl
            // 
            this.addNewStudLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudLbl.ForeColor = System.Drawing.Color.White;
            this.addNewStudLbl.Location = new System.Drawing.Point(35, 68);
            this.addNewStudLbl.Name = "addNewStudLbl";
            this.addNewStudLbl.Size = new System.Drawing.Size(348, 42);
            this.addNewStudLbl.TabIndex = 1;
            this.addNewStudLbl.Text = "Add New Student";
            this.addNewStudLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewStudLbl.Click += new System.EventHandler(this.addNewStudLbl_Click);
            // 
            // headingLbl
            // 
            this.headingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.ForeColor = System.Drawing.Color.White;
            this.headingLbl.Location = new System.Drawing.Point(365, 0);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(385, 59);
            this.headingLbl.TabIndex = 0;
            this.headingLbl.Text = "Student Management";
            this.headingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 649);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Student_Management";
            this.Text = "Student_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox roomNoCombo;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.RichTextBox studIdRichBox;
    }
}