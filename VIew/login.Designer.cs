namespace EduWatch_Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswoedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(187, 334);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswoedTextBox
            // 
            this.PasswoedTextBox.Location = new System.Drawing.Point(187, 386);
            this.PasswoedTextBox.Name = "PasswoedTextBox";
            this.PasswoedTextBox.Size = new System.Drawing.Size(175, 20);
            this.PasswoedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добре дошли в\r\nEduWatch!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(184, 315);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(151, 16);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Потребителско име:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(184, 367);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 16);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Парола:";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(235, 421);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(69, 33);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 207);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(565, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswoedTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswoedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

