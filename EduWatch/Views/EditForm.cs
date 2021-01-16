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
    public partial class EditForm : Form, IEditView
    {
        public EditForm()
        {
            InitializeComponent();
            foreach (var panel in Controls.OfType<Panel>()) panel.Location = new Point(90, 100);
        }

        public IEditPresenter Presenter { private get; set; }

        public string FirstNameTextBoxText { get => textBoxFirstName.Text; set => textBoxFirstName.Text = value; }
        public string LastNameTextBoxText { get => textBoxLastName.Text; set => textBoxLastName.Text = value; }

        public bool MainScreenVisible => panelMain.Visible;
        public bool ChangeNameScreenVisible => panelNames.Visible;
        public bool ChangePassScreenVisible => panelPass.Visible;
        public bool AddStudentScreenVisible => panelStudent.Visible;

        public string OldPassTextBoxText { get => textBoxOldPass.Text; set => textBoxOldPass.Text = value; }
        public string NewPassTextBoxText { get => textBoxPass1.Text; set => textBoxPass1.Text = value; }
        public string NewPassAgainTextBoxText { get => textBoxPass2.Text; set => textBoxPass2.Text = value; }
        public bool AddStudentButtonVisible { get => btnAddStudentScreen.Visible; set => btnAddStudentScreen.Visible = value; }
        public string StudentPinTextBoxText { get => textBoxStudentPin.Text; set => textBoxStudentPin.Text = value; }
        public string StudentCodeTextBoxText { get => textBoxCode.Text; set => textBoxCode.Text = value; }

        public void DisplayAddStudentScreen()
        {
            HideAllPanels();
            ClearText();
            panelStudent.Visible = true;
            panelStudent.BringToFront();
        }

        public void DisplayChangeNameScreen()
        {
            HideAllPanels();
            ClearText();
            panelNames.Visible = true;
            panelNames.BringToFront();
        }

        public void DisplayChangePassScreen()
        {
            HideAllPanels();
            ClearText();
            panelPass.Visible = true;
            panelPass.BringToFront();
        }

        public void DisplayMainScreen()
        {
            HideAllPanels();
            ClearText();
            panelMain.Visible = true;
            panelMain.BringToFront();
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

        private void goBackPic_Click(object sender, EventArgs e)
        {
            Presenter.OnBackButtonClick();
        }

        public void ShowAsModal()
        {
            ShowDialog();
        }

        void HideAllPanels()
        {
            foreach (var panel in Controls.OfType<Panel>()) panel.Visible = false;
        }

        void ClearText()
        {
            foreach (var panel in Controls.OfType<Panel>())
                foreach (var tb in panel.Controls.OfType<TextBox>())
                    tb.Text = string.Empty;
        }

        private void btnChangeNames_Click(object sender, EventArgs e)
        {
            Presenter.OnChangeNamesButtonClick();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Presenter.OnChangePassButtonClick();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Presenter.OnAddStudentButtonClick();
        }

        private void btnSaveNameChanges_Click(object sender, EventArgs e)
        {
            Presenter.OnSaveNameChangesButtonClick();
        }

        private void btnSavePassChanges_Click(object sender, EventArgs e)
        {
            Presenter.OnSavePassChangesButtonClick();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            Presenter.OnSaveStudentButtonClick();
        }
    }
}
