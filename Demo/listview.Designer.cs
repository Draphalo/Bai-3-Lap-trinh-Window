namespace Demo
{
    partial class listview
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
            listView1 = new ListView();
            LastName = new ColumnHeader();
            FirstName = new ColumnHeader();
            Phone = new ColumnHeader();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPhoneNumber = new TextBox();
            Addbtn = new Button();
            label1 = new Label();
            lblFirstName = new Label();
            lblPhone = new Label();
            Editbtn = new Button();
            Deletebtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { LastName, FirstName, Phone });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(47, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(456, 279);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // LastName
            // 
            LastName.Text = "LastName";
            LastName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.Text = "FirstName";
            FirstName.Width = 150;
            // 
            // Phone
            // 
            Phone.Text = "PhoneNumber";
            Phone.Width = 150;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(580, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(183, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(580, 194);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(183, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(580, 307);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(183, 31);
            txtPhoneNumber.TabIndex = 3;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(120, 388);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(135, 37);
            Addbtn.TabIndex = 4;
            Addbtn.Text = "Thêm";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(580, 142);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(580, 261);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(132, 25);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone Number";
            // 
            // Editbtn
            // 
            Editbtn.Location = new Point(351, 388);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(135, 37);
            Editbtn.TabIndex = 8;
            Editbtn.Text = "Sửa";
            Editbtn.UseVisualStyleBackColor = true;
            Editbtn.Click += Editbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(580, 388);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(135, 37);
            Deletebtn.TabIndex = 9;
            Deletebtn.Text = "Xoá";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // listview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(label1);
            Controls.Add(Addbtn);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(listView1);
            Name = "listview";
            Text = "listview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPhoneNumber;
        private Button Addbtn;
        private ColumnHeader LastName;
        private ColumnHeader FirstName;
        private ColumnHeader Phone;
        private Label label1;
        private Label lblFirstName;
        private Label lblPhone;
        private Button Editbtn;
        private Button Deletebtn;
    }
}