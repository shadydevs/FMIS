namespace FacultyMIS_PROJECT
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.courses = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.sReport = new System.Windows.Forms.Button();
            this.cReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21F);
            this.label1.Location = new System.Drawing.Point(470, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(415, 174);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(121, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(415, 222);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(121, 20);
            this.password.TabIndex = 2;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(571, 220);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(79, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // courses
            // 
            this.courses.Location = new System.Drawing.Point(539, 127);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(111, 105);
            this.courses.TabIndex = 6;
            this.courses.Text = "Access\r\nCourses";
            this.courses.UseVisualStyleBackColor = true;
            this.courses.Visible = false;
            this.courses.Click += new System.EventHandler(this.courses_Click);
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(415, 127);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(111, 105);
            this.students.TabIndex = 7;
            this.students.Text = "Access\r\nStudents";
            this.students.UseVisualStyleBackColor = true;
            this.students.Visible = false;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(564, 177);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(63, 13);
            this.error.TabIndex = 8;
            this.error.Text = "Login Failed";
            this.error.Visible = false;
            // 
            // sReport
            // 
            this.sReport.Location = new System.Drawing.Point(415, 248);
            this.sReport.Name = "sReport";
            this.sReport.Size = new System.Drawing.Size(111, 105);
            this.sReport.TabIndex = 9;
            this.sReport.Text = "Students\r\nReport";
            this.sReport.UseVisualStyleBackColor = true;
            this.sReport.Visible = false;
            this.sReport.Click += new System.EventHandler(this.sReport_Click);
            // 
            // cReport
            // 
            this.cReport.Location = new System.Drawing.Point(539, 248);
            this.cReport.Name = "cReport";
            this.cReport.Size = new System.Drawing.Size(111, 105);
            this.cReport.TabIndex = 10;
            this.cReport.Text = "Courses\r\nReport";
            this.cReport.UseVisualStyleBackColor = true;
            this.cReport.Visible = false;
            this.cReport.Click += new System.EventHandler(this.cReport_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 422);
            this.Controls.Add(this.cReport);
            this.Controls.Add(this.sReport);
            this.Controls.Add(this.error);
            this.Controls.Add(this.students);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Management Information System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button courses;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button sReport;
        private System.Windows.Forms.Button cReport;
    }

}