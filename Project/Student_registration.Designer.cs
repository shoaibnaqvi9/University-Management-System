namespace Project
{
    partial class Student_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_registration));
            this.lblDRF = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblStudentname = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentname = new System.Windows.Forms.TextBox();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDRF
            // 
            this.lblDRF.AutoSize = true;
            this.lblDRF.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblDRF.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDRF.Location = new System.Drawing.Point(72, 31);
            this.lblDRF.Name = "lblDRF";
            this.lblDRF.Size = new System.Drawing.Size(271, 22);
            this.lblDRF.TabIndex = 46;
            this.lblDRF.Text = "STUDENT REGISTRATION";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(243, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(84, 368);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 31);
            this.btnRegister.TabIndex = 47;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Bookman Old Style", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(197, 223);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(90, 13);
            this.lblmsg2.TabIndex = 59;
            this.lblmsg2.Text = "*must be 12 digits";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbladdress.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.SystemColors.Control;
            this.lbladdress.Location = new System.Drawing.Point(59, 247);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(69, 18);
            this.lbladdress.TabIndex = 57;
            this.lbladdress.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(200, 244);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(179, 23);
            this.txtaddress.TabIndex = 56;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblcontact.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcontact.Location = new System.Drawing.Point(59, 202);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(70, 18);
            this.lblcontact.TabIndex = 55;
            this.lblcontact.Text = "Contact";
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(200, 199);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(179, 23);
            this.txtcontact.TabIndex = 54;
            // 
            // lblStudentname
            // 
            this.lblStudentname.AutoSize = true;
            this.lblStudentname.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblStudentname.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudentname.Location = new System.Drawing.Point(59, 159);
            this.lblStudentname.Name = "lblStudentname";
            this.lblStudentname.Size = new System.Drawing.Size(124, 18);
            this.lblStudentname.TabIndex = 52;
            this.lblStudentname.Text = "Student  Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblStudentID.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudentID.Location = new System.Drawing.Point(59, 114);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(92, 18);
            this.lblStudentID.TabIndex = 51;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtStudentname
            // 
            this.txtStudentname.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentname.Location = new System.Drawing.Point(200, 156);
            this.txtStudentname.Name = "txtStudentname";
            this.txtStudentname.Size = new System.Drawing.Size(180, 23);
            this.txtStudentname.TabIndex = 50;
            // 
            // txtStudentid
            // 
            this.txtStudentid.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentid.Location = new System.Drawing.Point(200, 111);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(132, 23);
            this.txtStudentid.TabIndex = 49;
            // 
            // Student_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 451);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.lblStudentname);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentname);
            this.Controls.Add(this.txtStudentid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDRF);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Student_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student_registration";
            this.Load += new System.EventHandler(this.doctor_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDRF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lblStudentname;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentname;
        private System.Windows.Forms.TextBox txtStudentid;
    }
}