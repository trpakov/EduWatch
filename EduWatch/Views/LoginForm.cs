﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduWatch.Presenters;

namespace EduWatch.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        public string Username => userNameTextBox.Text;
        public string Pass => passwordTextBox.Text;

        public ILoginPresenter Presenter { private get;  set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public MessageResult Message(string msg, string caption, MessageIcon msgIcon, MessageButton msgBtn)
        {
            var result = MessageBox.Show(
                    msg,
                    caption,
                    (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                    );

            return (MessageResult)Enum.Parse(typeof(MessageResult), result.ToString());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Presenter.OnLoginButtonClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClick();
        }

        public IParentView CreateParentView() => new ParentForm();
        public ITeacherView CreateTeacherView() => new TeacherForm();
        public IAdminView CreateAdminView() => new AdminForm();

        public void StartApplication()
        {
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presenter.OnCreateAccountClick();
        }

        public ISignUpView CreateSignUpView() => new SignUpForm();
    }
}
