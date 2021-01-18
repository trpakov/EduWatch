using System;
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
    public partial class SignUpForm : Form, ISignUpView
    {
        public ISignUpPresenter Presenter { private get; set; }

        public string Username => textBoxUsername.Text;
        public string Pass => textBoxPassword.Text;
        public string Surname => textBoxSurname.Text;
        public string FirstName => textBoxName.Text;
        public char PasswordChar { get => textBoxPassword.PasswordChar; set => textBoxPassword.PasswordChar = value; }

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.OnCancelButtonClick();
        }

        public MessageResult Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            var result = MessageBox.Show(
                    msg,
                    caption,
                    (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                    );

            return (MessageResult)Enum.Parse(typeof(MessageResult), result.ToString());
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnPasswordVisibleCheckBoxChange();           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Presenter.OnCreateButtonClick();
        }

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            toolTip_name.Show("Въведете име на кирилица!", textBoxName);
        }

        private void textBoxSurname_MouseHover(object sender, EventArgs e)
        {
            toolTip_Sname.Show("Въведете фамилия на кирилица!", textBoxSurname);
        }

        private void textBoxUsername_MouseHover(object sender, EventArgs e)
        {
            toolTip_username.Show("Въведете с латински символи!", textBoxUsername);
        }
    }
}
