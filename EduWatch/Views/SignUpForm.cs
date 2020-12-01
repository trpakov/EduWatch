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
        public SignUpPresenter Presenter { private get; set; }

        public string Username => textBoxUsername.Text;
        public string Pass => textBoxPassword.Text;
        public string Surname => textBoxSurname.Text;
        public string FirstName => textBoxName.Text;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.OnCancelButtonClick();
        }

        public void Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            MessageBox.Show(
                msg,
                caption,
                (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                );
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnPasswordVisibleCheckBoxChange();
        }
    }
}
