namespace EduWatch.Views
{
    partial class EditForm
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnChangeNames = new System.Windows.Forms.Button();
            this.goBackPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goBackPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogo.Location = new System.Drawing.Point(146, 47);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(190, 59);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EduWatch";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.ForeColor = System.Drawing.Color.MintCream;
            this.lblFirstName.Location = new System.Drawing.Point(143, 128);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Име:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.ForeColor = System.Drawing.Color.MintCream;
            this.lblLastName.Location = new System.Drawing.Point(143, 185);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(146, 154);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(190, 26);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(146, 211);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(190, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(203, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Нова парола:";
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Location = new System.Drawing.Point(146, 276);
            this.textBoxPass1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(190, 20);
            this.textBoxPass1.TabIndex = 8;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePass.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChangePass.Location = new System.Drawing.Point(146, 184);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(190, 39);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.TabStop = false;
            this.btnChangePass.Text = "Промени парола";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddStudent.Location = new System.Drawing.Point(146, 243);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(190, 39);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.TabStop = false;
            this.btnAddStudent.Text = "Добави ученик";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeatPass.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeatPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRepeatPass.Location = new System.Drawing.Point(184, 268);
            this.lblRepeatPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(114, 17);
            this.lblRepeatPass.TabIndex = 11;
            this.lblRepeatPass.Text = "Повтори паролата:";
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(187, 265);
            this.textBoxPass2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(109, 20);
            this.textBoxPass2.TabIndex = 12;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveChanges.Location = new System.Drawing.Point(146, 265);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(190, 39);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Запази промените";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnChangeNames
            // 
            this.btnChangeNames.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeNames.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeNames.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChangeNames.Location = new System.Drawing.Point(146, 128);
            this.btnChangeNames.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeNames.Name = "btnChangeNames";
            this.btnChangeNames.Size = new System.Drawing.Size(190, 39);
            this.btnChangeNames.TabIndex = 1;
            this.btnChangeNames.TabStop = false;
            this.btnChangeNames.Text = "Промени име и фамилия";
            this.btnChangeNames.UseVisualStyleBackColor = false;
            this.btnChangeNames.Click += new System.EventHandler(this.btnChangeNames_Click);
            // 
            // goBackPic
            // 
            this.goBackPic.BackColor = System.Drawing.Color.Transparent;
            this.goBackPic.BackgroundImage = global::EduWatch.Properties.Resources.goback;
            this.goBackPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBackPic.Location = new System.Drawing.Point(50, 61);
            this.goBackPic.Margin = new System.Windows.Forms.Padding(2);
            this.goBackPic.Name = "goBackPic";
            this.goBackPic.Size = new System.Drawing.Size(23, 20);
            this.goBackPic.TabIndex = 15;
            this.goBackPic.TabStop = false;
            this.goBackPic.Click += new System.EventHandler(this.goBackPic_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EduWatch.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 393);
            this.Controls.Add(this.goBackPic);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnChangeNames);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.goBackPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnChangeNames;
        private System.Windows.Forms.PictureBox goBackPic;
    }
}