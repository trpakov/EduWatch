﻿namespace EduWatch.Views
{
    partial class ParentForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.radioButtonGrades = new System.Windows.Forms.RadioButton();
            this.radioButtonNotes = new System.Windows.Forms.RadioButton();
            this.LblName = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.toolTip_settings_PF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_exit_PF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_AG_PF = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(485, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "EduWatch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(231, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ученик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(800, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "Изберете предмет:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.Enabled = false;
            this.comboBoxSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(723, 313);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(412, 32);
            this.comboBoxSubject.TabIndex = 11;
            this.comboBoxSubject.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSubject_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(88, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Дневник:";
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.Control;
            this.btnAverage.Enabled = false;
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAverage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAverage.Location = new System.Drawing.Point(83, 721);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(168, 36);
            this.btnAverage.TabIndex = 16;
            this.btnAverage.Text = "Среден успех:";
            this.toolTip_AG_PF.SetToolTip(this.btnAverage, "Натиснете за пресмятане \r\n      на среден успех!");
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAverage.Location = new System.Drawing.Point(276, 721);
            this.textBoxAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(129, 37);
            this.textBoxAverage.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Brown;
            this.btnExit.Location = new System.Drawing.Point(963, 178);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Изход";
            this.toolTip_exit_PF.SetToolTip(this.btnExit, "Натиснете за изход \r\n     от системата!");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 505);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 197);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStudent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(141, 313);
            this.comboBoxStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(279, 32);
            this.comboBoxStudent.TabIndex = 21;
            this.comboBoxStudent.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStudent_SelectionChangeCommited);
            // 
            // radioButtonGrades
            // 
            this.radioButtonGrades.AutoSize = true;
            this.radioButtonGrades.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGrades.Checked = true;
            this.radioButtonGrades.Enabled = false;
            this.radioButtonGrades.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGrades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonGrades.Location = new System.Drawing.Point(821, 359);
            this.radioButtonGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonGrades.Name = "radioButtonGrades";
            this.radioButtonGrades.Size = new System.Drawing.Size(84, 28);
            this.radioButtonGrades.TabIndex = 22;
            this.radioButtonGrades.TabStop = true;
            this.radioButtonGrades.Text = "оценки";
            this.radioButtonGrades.UseVisualStyleBackColor = false;
            this.radioButtonGrades.CheckedChanged += new System.EventHandler(this.radioButtonGrades_CheckedChanged);
            // 
            // radioButtonNotes
            // 
            this.radioButtonNotes.AutoSize = true;
            this.radioButtonNotes.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNotes.Enabled = false;
            this.radioButtonNotes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonNotes.Location = new System.Drawing.Point(944, 359);
            this.radioButtonNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNotes.Name = "radioButtonNotes";
            this.radioButtonNotes.Size = new System.Drawing.Size(112, 28);
            this.radioButtonNotes.TabIndex = 23;
            this.radioButtonNotes.TabStop = true;
            this.radioButtonNotes.Text = "забележки";
            this.radioButtonNotes.UseVisualStyleBackColor = false;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblName.Location = new System.Drawing.Point(919, 89);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(232, 28);
            this.LblName.TabIndex = 24;
            this.LblName.Text = "*името на родителя*";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.Location = new System.Drawing.Point(963, 134);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(145, 37);
            this.btnSettings.TabIndex = 26;
            this.btnSettings.Text = "Настройки";
            this.toolTip_settings_PF.SetToolTip(this.btnSettings, "Натиснете за настройка\r\n       на профила!");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::EduWatch.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 811);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.radioButtonNotes);
            this.Controls.Add(this.radioButtonGrades);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.RadioButton radioButtonGrades;
        private System.Windows.Forms.RadioButton radioButtonNotes;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip toolTip_AG_PF;
        private System.Windows.Forms.ToolTip toolTip_exit_PF;
        private System.Windows.Forms.ToolTip toolTip_settings_PF;
    }
}