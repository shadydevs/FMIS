namespace FacultyMIS_PROJECT
{
    partial class CoursesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.DataGridView();
            this.courseId = new System.Windows.Forms.RadioButton();
            this.courseName = new System.Windows.Forms.RadioButton();
            this.numOfCredits = new System.Windows.Forms.RadioButton();
            this.lecName = new System.Windows.Forms.RadioButton();
            this.semOffered = new System.Windows.Forms.RadioButton();
            this.fall = new System.Windows.Forms.CheckBox();
            this.spring = new System.Windows.Forms.CheckBox();
            this.cidBox = new System.Windows.Forms.ComboBox();
            this.lecNameBox = new System.Windows.Forms.ComboBox();
            this.numOfCreditsBox = new System.Windows.Forms.ComboBox();
            this.cNameBox = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Courses";
            // 
            // courses
            // 
            this.courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses.Location = new System.Drawing.Point(40, 177);
            this.courses.Name = "courses";
            this.courses.RowHeadersWidth = 51;
            this.courses.RowTemplate.Height = 26;
            this.courses.Size = new System.Drawing.Size(770, 282);
            this.courses.TabIndex = 3;
            // 
            // courseId
            // 
            this.courseId.AutoSize = true;
            this.courseId.Location = new System.Drawing.Point(40, 57);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(71, 18);
            this.courseId.TabIndex = 4;
            this.courseId.TabStop = true;
            this.courseId.Text = "Course ID";
            this.courseId.UseVisualStyleBackColor = true;
            this.courseId.CheckedChanged += new System.EventHandler(this.courseId_CheckedChanged);
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(40, 81);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(86, 18);
            this.courseName.TabIndex = 5;
            this.courseName.TabStop = true;
            this.courseName.Text = "Course Name";
            this.courseName.UseVisualStyleBackColor = true;
            this.courseName.CheckedChanged += new System.EventHandler(this.courseName_CheckedChanged);
            // 
            // numOfCredits
            // 
            this.numOfCredits.AutoSize = true;
            this.numOfCredits.Location = new System.Drawing.Point(40, 105);
            this.numOfCredits.Name = "numOfCredits";
            this.numOfCredits.Size = new System.Drawing.Size(107, 18);
            this.numOfCredits.TabIndex = 6;
            this.numOfCredits.TabStop = true;
            this.numOfCredits.Text = "Number of credits";
            this.numOfCredits.UseVisualStyleBackColor = true;
            this.numOfCredits.CheckedChanged += new System.EventHandler(this.numOfCredits_CheckedChanged);
            // 
            // lecName
            // 
            this.lecName.AutoSize = true;
            this.lecName.Location = new System.Drawing.Point(40, 129);
            this.lecName.Name = "lecName";
            this.lecName.Size = new System.Drawing.Size(94, 18);
            this.lecName.TabIndex = 7;
            this.lecName.TabStop = true;
            this.lecName.Text = "Lecturer Name";
            this.lecName.UseVisualStyleBackColor = true;
            this.lecName.CheckedChanged += new System.EventHandler(this.lecName_CheckedChanged);
            // 
            // semOffered
            // 
            this.semOffered.AutoSize = true;
            this.semOffered.Location = new System.Drawing.Point(40, 153);
            this.semOffered.Name = "semOffered";
            this.semOffered.Size = new System.Drawing.Size(104, 18);
            this.semOffered.TabIndex = 8;
            this.semOffered.TabStop = true;
            this.semOffered.Text = "Semester Offered";
            this.semOffered.UseVisualStyleBackColor = true;
            this.semOffered.CheckedChanged += new System.EventHandler(this.semOffered_CheckedChanged);
            // 
            // fall
            // 
            this.fall.AutoSize = true;
            this.fall.Enabled = false;
            this.fall.Location = new System.Drawing.Point(162, 153);
            this.fall.Name = "fall";
            this.fall.Size = new System.Drawing.Size(43, 18);
            this.fall.TabIndex = 13;
            this.fall.Text = "Fall";
            this.fall.UseVisualStyleBackColor = true;
            this.fall.CheckedChanged += new System.EventHandler(this.fall_CheckedChanged);
            // 
            // spring
            // 
            this.spring.AutoSize = true;
            this.spring.Enabled = false;
            this.spring.Location = new System.Drawing.Point(211, 153);
            this.spring.Name = "spring";
            this.spring.Size = new System.Drawing.Size(55, 18);
            this.spring.TabIndex = 14;
            this.spring.Text = "Spring";
            this.spring.UseVisualStyleBackColor = true;
            this.spring.CheckedChanged += new System.EventHandler(this.spring_CheckedChanged);
            // 
            // cidBox
            // 
            this.cidBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cidBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cidBox.Enabled = false;
            this.cidBox.FormattingEnabled = true;
            this.cidBox.Location = new System.Drawing.Point(162, 53);
            this.cidBox.Name = "cidBox";
            this.cidBox.Size = new System.Drawing.Size(121, 20);
            this.cidBox.TabIndex = 15;
            this.cidBox.SelectedIndexChanged += new System.EventHandler(this.cidBox_SelectedIndexChanged);
            // 
            // lecNameBox
            // 
            this.lecNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lecNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lecNameBox.Enabled = false;
            this.lecNameBox.FormattingEnabled = true;
            this.lecNameBox.Location = new System.Drawing.Point(162, 131);
            this.lecNameBox.Name = "lecNameBox";
            this.lecNameBox.Size = new System.Drawing.Size(121, 20);
            this.lecNameBox.TabIndex = 17;
            this.lecNameBox.SelectedIndexChanged += new System.EventHandler(this.lecNameBox_SelectedIndexChanged);
            // 
            // numOfCreditsBox
            // 
            this.numOfCreditsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.numOfCreditsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.numOfCreditsBox.Enabled = false;
            this.numOfCreditsBox.FormattingEnabled = true;
            this.numOfCreditsBox.Items.AddRange(new object[] {
                "1",
                "2",
                "3",
                "4"});
            this.numOfCreditsBox.Location = new System.Drawing.Point(162, 105);
            this.numOfCreditsBox.Name = "numOfCreditsBox";
            this.numOfCreditsBox.Size = new System.Drawing.Size(121, 20);
            this.numOfCreditsBox.TabIndex = 18;
            this.numOfCreditsBox.SelectedIndexChanged += new System.EventHandler(this.numOfCreditsBox_SelectedIndexChanged);
            // 
            // cNameBox
            // 
            this.cNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cNameBox.Enabled = false;
            this.cNameBox.FormattingEnabled = true;
            this.cNameBox.Location = new System.Drawing.Point(162, 79);
            this.cNameBox.Name = "cNameBox";
            this.cNameBox.Size = new System.Drawing.Size(121, 20);
            this.cNameBox.TabIndex = 19;
            this.cNameBox.SelectedIndexChanged += new System.EventHandler(this.cNameBox_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.save.Location = new System.Drawing.Point(816, 177);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 32);
            this.save.TabIndex = 20;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 471);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cNameBox);
            this.Controls.Add(this.numOfCreditsBox);
            this.Controls.Add(this.lecNameBox);
            this.Controls.Add(this.cidBox);
            this.Controls.Add(this.spring);
            this.Controls.Add(this.fall);
            this.Controls.Add(this.semOffered);
            this.Controls.Add(this.lecName);
            this.Controls.Add(this.numOfCredits);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseId);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoursesForm_FormClosed);
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView courses;
        private System.Windows.Forms.RadioButton courseId;
        private System.Windows.Forms.RadioButton courseName;
        private System.Windows.Forms.RadioButton numOfCredits;
        private System.Windows.Forms.RadioButton lecName;
        private System.Windows.Forms.RadioButton semOffered;
        private System.Windows.Forms.CheckBox fall;
        private System.Windows.Forms.CheckBox spring;
        private System.Windows.Forms.ComboBox cidBox;
        private System.Windows.Forms.ComboBox lecNameBox;
        private System.Windows.Forms.ComboBox numOfCreditsBox;
        private System.Windows.Forms.ComboBox cNameBox;
        private System.Windows.Forms.Button save;
    }

}