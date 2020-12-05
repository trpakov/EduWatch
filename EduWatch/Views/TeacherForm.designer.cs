namespace EduWatch.Views
{
    partial class TeacherForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.radioButtonGrade = new System.Windows.Forms.RadioButton();
            this.radioButtonNote = new System.Windows.Forms.RadioButton();
            this.SeeDatabtn = new System.Windows.Forms.Button();
            this.teachersNameLabel = new System.Windows.Forms.Label();
            this.labelAverageGrade = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.AddRecordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGrade1to12 = new System.Windows.Forms.ComboBox();
            this.averageGradeTextBox = new System.Windows.Forms.TextBox();
            this.toolTip_teacher_new = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_teacher_add = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_teacher_exit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_teacher_grade = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_teacher_look = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(499, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "EduWatch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(77, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Изберете предмет:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(77, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ученик:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(511, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Съдържание:";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Savebtn.Location = new System.Drawing.Point(677, 554);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(191, 65);
            this.Savebtn.TabIndex = 18;
            this.Savebtn.Text = "Добави";
            this.toolTip_teacher_add.SetToolTip(this.Savebtn, "Добавете в системата!");
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Red;
            this.Exitbtn.Location = new System.Drawing.Point(1066, 129);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(100, 33);
            this.Exitbtn.TabIndex = 19;
            this.Exitbtn.Text = "Изход";
            this.toolTip_teacher_exit.SetToolTip(this.Exitbtn, "Натиснете за излизане\r\n   от системата!");
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.Transparent;
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAverage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAverage.Location = new System.Drawing.Point(663, 727);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(205, 41);
            this.btnAverage.TabIndex = 21;
            this.btnAverage.Text = "Среден успех:";
            this.toolTip_teacher_grade.SetToolTip(this.btnAverage, "Натиснете за пресмятане \r\n на среде успех!");
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(714, 250);
            this.dataGridView1.TabIndex = 23;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(82, 396);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(383, 24);
            this.comboBoxSubject.TabIndex = 25;
            this.comboBoxSubject.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSubject_SelectionChangeCommitted);
            // 
            // radioButtonGrade
            // 
            this.radioButtonGrade.AutoSize = true;
            this.radioButtonGrade.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGrade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGrade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonGrade.Location = new System.Drawing.Point(102, 554);
            this.radioButtonGrade.Name = "radioButtonGrade";
            this.radioButtonGrade.Size = new System.Drawing.Size(89, 28);
            this.radioButtonGrade.TabIndex = 26;
            this.radioButtonGrade.TabStop = true;
            this.radioButtonGrade.Text = " оценка";
            this.radioButtonGrade.UseVisualStyleBackColor = false;
            this.radioButtonGrade.CheckedChanged += new System.EventHandler(this.radioButtonGrade_CheckedChanged);
            // 
            // radioButtonNote
            // 
            this.radioButtonNote.AutoSize = true;
            this.radioButtonNote.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNote.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonNote.Location = new System.Drawing.Point(291, 554);
            this.radioButtonNote.Name = "radioButtonNote";
            this.radioButtonNote.Size = new System.Drawing.Size(117, 28);
            this.radioButtonNote.TabIndex = 27;
            this.radioButtonNote.TabStop = true;
            this.radioButtonNote.Text = " забележка";
            this.radioButtonNote.UseVisualStyleBackColor = false;
            // 
            // SeeDatabtn
            // 
            this.SeeDatabtn.BackColor = System.Drawing.Color.Transparent;
            this.SeeDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeDatabtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeDatabtn.ForeColor = System.Drawing.Color.Transparent;
            this.SeeDatabtn.Location = new System.Drawing.Point(56, 628);
            this.SeeDatabtn.Name = "SeeDatabtn";
            this.SeeDatabtn.Size = new System.Drawing.Size(203, 51);
            this.SeeDatabtn.TabIndex = 28;
            this.SeeDatabtn.Text = "Виж дневника";
            this.toolTip_teacher_look.SetToolTip(this.SeeDatabtn, "Натиснете, за да видите\r\n           дневника!");
            this.SeeDatabtn.UseVisualStyleBackColor = false;
            this.SeeDatabtn.Click += new System.EventHandler(this.SeeDatabtn_Click);
            // 
            // teachersNameLabel
            // 
            this.teachersNameLabel.AutoSize = true;
            this.teachersNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.teachersNameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teachersNameLabel.Location = new System.Drawing.Point(1032, 90);
            this.teachersNameLabel.Name = "teachersNameLabel";
            this.teachersNameLabel.Size = new System.Drawing.Size(168, 24);
            this.teachersNameLabel.TabIndex = 29;
            this.teachersNameLabel.Text = "*името на учителя*";
            // 
            // labelAverageGrade
            // 
            this.labelAverageGrade.AutoSize = true;
            this.labelAverageGrade.BackColor = System.Drawing.Color.Transparent;
            this.labelAverageGrade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverageGrade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAverageGrade.Location = new System.Drawing.Point(898, 803);
            this.labelAverageGrade.Name = "labelAverageGrade";
            this.labelAverageGrade.Size = new System.Drawing.Size(0, 24);
            this.labelAverageGrade.TabIndex = 30;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(82, 468);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(383, 24);
            this.comboBoxStudent.TabIndex = 31;
            this.comboBoxStudent.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStudent_SelectionChangeCommitted);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(547, 384);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(417, 63);
            this.commentTextBox.TabIndex = 32;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GradeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GradeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GradeLabel.Location = new System.Drawing.Point(1032, 357);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(71, 24);
            this.GradeLabel.TabIndex = 34;
            this.GradeLabel.Text = "Оценка:";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CommentLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CommentLabel.Location = new System.Drawing.Point(544, 354);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(0, 24);
            this.CommentLabel.TabIndex = 35;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(1025, 384);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 24);
            this.gradeComboBox.TabIndex = 36;
            // 
            // AddRecordbtn
            // 
            this.AddRecordbtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordbtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddRecordbtn.Location = new System.Drawing.Point(265, 628);
            this.AddRecordbtn.Name = "AddRecordbtn";
            this.AddRecordbtn.Size = new System.Drawing.Size(212, 51);
            this.AddRecordbtn.TabIndex = 37;
            this.AddRecordbtn.Text = "Добави  нов запис";
            this.toolTip_teacher_new.SetToolTip(this.AddRecordbtn, "Натиснете за ново \r\n  въвеждане!");
            this.AddRecordbtn.UseVisualStyleBackColor = false;
            this.AddRecordbtn.Click += new System.EventHandler(this.AddRecordbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(77, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Клас:";
            // 
            // comboBoxGrade1to12
            // 
            this.comboBoxGrade1to12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade1to12.FormattingEnabled = true;
            this.comboBoxGrade1to12.Location = new System.Drawing.Point(145, 309);
            this.comboBoxGrade1to12.Name = "comboBoxGrade1to12";
            this.comboBoxGrade1to12.Size = new System.Drawing.Size(64, 24);
            this.comboBoxGrade1to12.TabIndex = 39;
            // 
            // averageGradeTextBox
            // 
            this.averageGradeTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageGradeTextBox.Location = new System.Drawing.Point(875, 730);
            this.averageGradeTextBox.Multiline = true;
            this.averageGradeTextBox.Name = "averageGradeTextBox";
            this.averageGradeTextBox.ReadOnly = true;
            this.averageGradeTextBox.Size = new System.Drawing.Size(119, 38);
            this.averageGradeTextBox.TabIndex = 40;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::EduWatch.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 911);
            this.Controls.Add(this.averageGradeTextBox);
            this.Controls.Add(this.comboBoxGrade1to12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddRecordbtn);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.labelAverageGrade);
            this.Controls.Add(this.teachersNameLabel);
            this.Controls.Add(this.SeeDatabtn);
            this.Controls.Add(this.radioButtonNote);
            this.Controls.Add(this.radioButtonGrade);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherForm";
            this.Text = "Teacher";
            this.toolTip_teacher_add.SetToolTip(this, "Добавете в системата!");
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.RadioButton radioButtonGrade;
        private System.Windows.Forms.RadioButton radioButtonNote;
        private System.Windows.Forms.Button SeeDatabtn;
        private System.Windows.Forms.Label teachersNameLabel;
        private System.Windows.Forms.Label labelAverageGrade;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Button AddRecordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGrade1to12;
        private System.Windows.Forms.TextBox averageGradeTextBox;
        private System.Windows.Forms.ToolTip toolTip_teacher_add;
        private System.Windows.Forms.ToolTip toolTip_teacher_exit;
        private System.Windows.Forms.ToolTip toolTip_teacher_new;
        private System.Windows.Forms.ToolTip toolTip_teacher_grade;
        private System.Windows.Forms.ToolTip toolTip_teacher_look;
    }
}