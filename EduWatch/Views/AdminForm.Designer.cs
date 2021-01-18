namespace EduWatch.Views
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.DeleteInfoBTN = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.comboBoxUsername = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.firstNLabel = new System.Windows.Forms.Label();
            this.LastNLabel = new System.Windows.Forms.Label();
            this.subject1gradeLabel = new System.Windows.Forms.Label();
            this.firstNTextBox = new System.Windows.Forms.TextBox();
            this.lastNTextBox = new System.Windows.Forms.TextBox();
            this.PINLabel = new System.Windows.Forms.Label();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.adminLabelText = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.AddInfoBTN = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.checkPictureBox = new System.Windows.Forms.PictureBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.toolTip_name_tbox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_sn_tb = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_check = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_update = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_delete_AF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_add_AF = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_exit_AF = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxPassVisible = new System.Windows.Forms.CheckBox();
            this.toolTip_username = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(376, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "EduWatch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(476, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вид профил:";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(383, 255);
            this.comboBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(308, 24);
            this.comboBoxProfile.TabIndex = 4;
            this.comboBoxProfile.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProfile_SelectionChangeCommitted);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Location = new System.Drawing.Point(869, 242);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 41);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Добавяне";
            this.toolTip_add_AF.SetToolTip(this.addBtn, "Натиснете за добавяне \r\n        на профил!");
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(717, 242);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(145, 41);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Изтриване";
            this.toolTip_delete_AF.SetToolTip(this.deleteBtn, "Натиснете за изтриване \r\n        на профил!");
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DeleteInfoBTN
            // 
            this.DeleteInfoBTN.BackColor = System.Drawing.Color.Red;
            this.DeleteInfoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteInfoBTN.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInfoBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteInfoBTN.Location = new System.Drawing.Point(373, 511);
            this.DeleteInfoBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteInfoBTN.Name = "DeleteInfoBTN";
            this.DeleteInfoBTN.Size = new System.Drawing.Size(317, 57);
            this.DeleteInfoBTN.TabIndex = 19;
            this.DeleteInfoBTN.Text = "ИЗТРИЙ";
            this.DeleteInfoBTN.UseVisualStyleBackColor = false;
            this.DeleteInfoBTN.Click += new System.EventHandler(this.DeleteInfoBTN_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(869, 118);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 39);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Изход";
            this.toolTip_exit_AF.SetToolTip(this.exitBtn, "Натиснете за изход\r\n    от системата!");
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userNameLabel.Location = new System.Drawing.Point(65, 271);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(211, 29);
            this.userNameLabel.TabIndex = 21;
            this.userNameLabel.Text = "Потребителско име:";
            // 
            // comboBoxUsername
            // 
            this.comboBoxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsername.FormattingEnabled = true;
            this.comboBoxUsername.Location = new System.Drawing.Point(71, 302);
            this.comboBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUsername.Name = "comboBoxUsername";
            this.comboBoxUsername.Size = new System.Drawing.Size(207, 24);
            this.comboBoxUsername.TabIndex = 22;
            this.comboBoxUsername.SelectionChangeCommitted += new System.EventHandler(this.comboBoxUsername_SelectionChangeCommitted);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(69, 303);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(207, 22);
            this.usernameTextBox.TabIndex = 23;
            this.toolTip_username.SetToolTip(this.usernameTextBox, "Въведете с латински символи!");
            this.usernameTextBox.MouseHover += new System.EventHandler(this.usernameTextBox_MouseHover);
            // 
            // firstNLabel
            // 
            this.firstNLabel.AutoSize = true;
            this.firstNLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.firstNLabel.Location = new System.Drawing.Point(508, 351);
            this.firstNLabel.Name = "firstNLabel";
            this.firstNLabel.Size = new System.Drawing.Size(47, 24);
            this.firstNLabel.TabIndex = 24;
            this.firstNLabel.Text = "Име:";
            // 
            // LastNLabel
            // 
            this.LastNLabel.AutoSize = true;
            this.LastNLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastNLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LastNLabel.Location = new System.Drawing.Point(485, 411);
            this.LastNLabel.Name = "LastNLabel";
            this.LastNLabel.Size = new System.Drawing.Size(84, 24);
            this.LastNLabel.TabIndex = 25;
            this.LastNLabel.Text = "Фамилия:";
            // 
            // subject1gradeLabel
            // 
            this.subject1gradeLabel.AutoSize = true;
            this.subject1gradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.subject1gradeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject1gradeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subject1gradeLabel.Location = new System.Drawing.Point(117, 351);
            this.subject1gradeLabel.Name = "subject1gradeLabel";
            this.subject1gradeLabel.Size = new System.Drawing.Size(88, 24);
            this.subject1gradeLabel.TabIndex = 26;
            this.subject1gradeLabel.Text = "Предмет:";
            // 
            // firstNTextBox
            // 
            this.firstNTextBox.Location = new System.Drawing.Point(448, 378);
            this.firstNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNTextBox.Name = "firstNTextBox";
            this.firstNTextBox.Size = new System.Drawing.Size(169, 22);
            this.firstNTextBox.TabIndex = 27;
            this.toolTip_name_tbox.SetToolTip(this.firstNTextBox, "Моля, въведете името\r\n      на кирилица!");
            this.firstNTextBox.MouseHover += new System.EventHandler(this.firstNTextBox_MouseHover);
            // 
            // lastNTextBox
            // 
            this.lastNTextBox.Location = new System.Drawing.Point(445, 438);
            this.lastNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNTextBox.Name = "lastNTextBox";
            this.lastNTextBox.Size = new System.Drawing.Size(172, 22);
            this.lastNTextBox.TabIndex = 28;
            this.toolTip_sn_tb.SetToolTip(this.lastNTextBox, "Моля, въведете фамилията\r\n        на кирилица!");
            this.lastNTextBox.MouseHover += new System.EventHandler(this.lastNTextBox_MouseHover);
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.BackColor = System.Drawing.Color.Transparent;
            this.PINLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PINLabel.Location = new System.Drawing.Point(137, 411);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(47, 24);
            this.PINLabel.TabIndex = 30;
            this.PINLabel.Text = "ЕГН:";
            // 
            // PINTextBox
            // 
            this.PINTextBox.Location = new System.Drawing.Point(84, 438);
            this.PINTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(153, 22);
            this.PINTextBox.TabIndex = 31;
            // 
            // adminLabelText
            // 
            this.adminLabelText.AutoSize = true;
            this.adminLabelText.BackColor = System.Drawing.Color.Transparent;
            this.adminLabelText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminLabelText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLabelText.Location = new System.Drawing.Point(867, 79);
            this.adminLabelText.Name = "adminLabelText";
            this.adminLabelText.Size = new System.Drawing.Size(54, 24);
            this.adminLabelText.TabIndex = 33;
            this.adminLabelText.Text = "label8";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(71, 377);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGrade.TabIndex = 34;
            // 
            // AddInfoBTN
            // 
            this.AddInfoBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddInfoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInfoBTN.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInfoBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddInfoBTN.Location = new System.Drawing.Point(373, 511);
            this.AddInfoBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AddInfoBTN.Name = "AddInfoBTN";
            this.AddInfoBTN.Size = new System.Drawing.Size(317, 57);
            this.AddInfoBTN.TabIndex = 35;
            this.AddInfoBTN.Text = "Добави";
            this.toolTip_update.SetToolTip(this.AddInfoBTN, "Натиснете, за да обновите\r\n            данните!");
            this.AddInfoBTN.UseVisualStyleBackColor = false;
            this.AddInfoBTN.Click += new System.EventHandler(this.AddInfoBTN_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(781, 357);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 24);
            this.passwordLabel.TabIndex = 36;
            this.passwordLabel.Text = "Парола:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(749, 384);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(153, 22);
            this.passwordTextBox.TabIndex = 37;
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.checkPictureBox.BackgroundImage = global::EduWatch.Properties.Resources.checkpic;
            this.checkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPictureBox.Location = new System.Drawing.Point(253, 431);
            this.checkPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPictureBox.Name = "checkPictureBox";
            this.checkPictureBox.Size = new System.Drawing.Size(35, 30);
            this.checkPictureBox.TabIndex = 40;
            this.checkPictureBox.TabStop = false;
            this.toolTip_check.SetToolTip(this.checkPictureBox, "Проверете дали съществува\r\n        лице с това ЕГН!");
            this.checkPictureBox.Click += new System.EventHandler(this.checkPictureBox_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(95, 378);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(137, 22);
            this.subjectTextBox.TabIndex = 41;
            // 
            // toolTip_name_tbox
            // 
            this.toolTip_name_tbox.ShowAlways = true;
            // 
            // toolTip_sn_tb
            // 
            this.toolTip_sn_tb.ShowAlways = true;
            // 
            // checkBoxPassVisible
            // 
            this.checkBoxPassVisible.AutoSize = true;
            this.checkBoxPassVisible.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPassVisible.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPassVisible.ForeColor = System.Drawing.Color.White;
            this.checkBoxPassVisible.Location = new System.Drawing.Point(765, 409);
            this.checkBoxPassVisible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPassVisible.Name = "checkBoxPassVisible";
            this.checkBoxPassVisible.Size = new System.Drawing.Size(129, 26);
            this.checkBoxPassVisible.TabIndex = 42;
            this.checkBoxPassVisible.Text = "виж паролата";
            this.checkBoxPassVisible.UseVisualStyleBackColor = false;
            this.checkBoxPassVisible.CheckedChanged += new System.EventHandler(this.checkBoxPassVisible_CheckedChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::EduWatch.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 652);
            this.Controls.Add(this.checkBoxPassVisible);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.checkPictureBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.AddInfoBTN);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.adminLabelText);
            this.Controls.Add(this.PINTextBox);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.lastNTextBox);
            this.Controls.Add(this.firstNTextBox);
            this.Controls.Add(this.subject1gradeLabel);
            this.Controls.Add(this.LastNLabel);
            this.Controls.Add(this.firstNLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.comboBoxUsername);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.DeleteInfoBTN);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button DeleteInfoBTN;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ComboBox comboBoxUsername;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label firstNLabel;
        private System.Windows.Forms.Label LastNLabel;
        private System.Windows.Forms.Label subject1gradeLabel;
        private System.Windows.Forms.TextBox firstNTextBox;
        private System.Windows.Forms.TextBox lastNTextBox;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.Label adminLabelText;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Button AddInfoBTN;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox checkPictureBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.ToolTip toolTip_add_AF;
        private System.Windows.Forms.ToolTip toolTip_delete_AF;
        private System.Windows.Forms.ToolTip toolTip_exit_AF;
        private System.Windows.Forms.ToolTip toolTip_name_tbox;
        private System.Windows.Forms.ToolTip toolTip_sn_tb;
        private System.Windows.Forms.ToolTip toolTip_update;
        private System.Windows.Forms.ToolTip toolTip_check;
        private System.Windows.Forms.CheckBox checkBoxPassVisible;
        private System.Windows.Forms.ToolTip toolTip_username;
    }
}