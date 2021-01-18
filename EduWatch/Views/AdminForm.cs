using EduWatch.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduWatch.Views
{
    public partial class AdminForm : Form, IAdminView
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminPresenter Presenter { private get; set; }
        public string AdminLabelText { get => adminLabelText.Text; set => adminLabelText.Text = value; }
        public string ComboBoxProfile { get => comboBoxProfile.SelectedItem.ToString(); set => comboBoxProfile.SelectedItem = value; }
        public string FirstNTextBox { get => firstNTextBox.Text; set => firstNTextBox.Text = value; }
        public string LastNTextBox { get => lastNTextBox.Text; set => lastNTextBox.Text = value; }
        public string UserNameTextBox { get => usernameTextBox.Text; set => usernameTextBox.Text = value; }
        public string ComboBoxUserName { get => comboBoxUsername.SelectedItem.ToString(); set => comboBoxUsername.SelectedItem = value; }
        public string TextBoxSubject { get => subjectTextBox.Text; set => subjectTextBox.Text = value; }
        public string ComboBoxGrade { get => comboBoxGrade.SelectedItem?.ToString(); set => comboBoxGrade.SelectedItem= value; }

        public string typeOfProfile => comboBoxProfile.SelectedItem?.ToString();

        public bool IsbtnDeleteVisible => deleteBtn.Visible;

        public bool IsbtnAddVisible => addBtn.Visible;

        public bool IsUserNameTextBoxVisible => usernameTextBox.Visible;

        public bool IsUserNameComboBoxVisible => comboBoxUsername.Visible;

        public bool IsPINTextBoxVisible => PINTextBox.Visible;

        public bool IsSubjectTextBoxVisible => subjectTextBox.Visible;

        string IAdminView.PINTextBox { get => PINTextBox.Text; set => PINTextBox.Text = value; }

        public bool IsBTNAddisible  => AddInfoBTN.Visible;

        public bool IsBTNDeleteVisible { get => DeleteInfoBTN.Visible; set => DeleteInfoBTN.Visible = value; }

        public bool IsFirstNTextBoxVisible => firstNTextBox.Visible;

        public bool IsLastNTextBoxVisible => lastNTextBox.Visible;

        public bool IsSubjectGradeLabelVisible => subject1gradeLabel.Visible;

        public bool IsPINLabelVisible => PINLabel.Visible;
        
        public int ComboBoxUserNameSelectedIndex { get => comboBoxUsername.SelectedIndex; set =>comboBoxUsername.SelectedIndex=value; }

        public int SelectedUserNameID => (int)comboBoxUsername.SelectedValue;

        public char PasswordTextBox { get => passwordTextBox.PasswordChar; set => passwordTextBox.PasswordChar=value; }

        public bool IsPasswordTextBoxVisible => passwordTextBox.Visible;

        public bool IsPasswordLabelVisible => passwordTextBox.Visible;
        public string StudentNumberTextBox { get =>studentNumberTextBox.Text; set => studentNumberTextBox.Text = value; }

        public bool IsStudentNumberTextBoxVisivle => studentNumberTextBox.Visible;

        public bool IsStudentNumberLabelVisible => studentNumberLabel.Visible;

        public bool IsCheckBtnVisible => checkPictureBox.Visible;

        public string Password => passwordTextBox.Text;

        public void FillInProfile(string[] typeOfProfiles)
        {
            comboBoxProfile.Items.AddRange(typeOfProfiles);
        }

        public void FillInWhichGrade(string[] grade)
        {
            comboBoxGrade.Items.AddRange(grade);
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

        public void AdminStartView()
        {
            HideAll();
            ClearText();
            addBtn.Visible = true;
            deleteBtn.Visible = true;
            ShowDialog();
        }

        public void HideAll()
        {
            deleteBtn.Visible = false;

            addBtn.Visible = false;

            usernameTextBox.Visible = false;

            comboBoxUsername.Visible = false;          

            PINTextBox.Visible = false;

            subjectTextBox.Visible = false;

           
            AddInfoBTN.Visible=false;
           
            DeleteInfoBTN.Visible=false;

            firstNTextBox.Visible = false;
            lastNTextBox.Visible = false;
            subject1gradeLabel.Visible = false;
            PINLabel.Visible = false;
            userNameLabel.Visible = false;
            firstNLabel.Visible = false;
            LastNLabel.Visible = false;
            comboBoxGrade.Visible = false;
            passwordTextBox.Visible = false;
            passwordLabel.Visible = false;
            studentNumberLabel.Visible = false;
            studentNumberTextBox.Visible = false;
            checkPictureBox.Visible = false;
            checkBoxPassVisible.Visible = false;

    }
        public void ClearText()
        {
            usernameTextBox.Text = string.Empty;

            comboBoxUsername.Text = string.Empty;

            PINTextBox.Text = string.Empty;

            subjectTextBox.Text = string.Empty;

            firstNTextBox.Text = string.Empty;
            lastNTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;         
            studentNumberTextBox.Text = string.Empty;


        }

        public void FillInCorrespondingUserNames(string[] usernames)
        {
            comboBoxUsername.Items.Clear();
            comboBoxUsername.Items.AddRange(usernames);
        }


      
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            HideAll();
            ClearText();
            firstNTextBox.Enabled = false;
            lastNTextBox.Enabled = false;
                if(typeOfProfile=="Учител")
                {

                    comboBoxUsername.Visible = true;
                    firstNTextBox.Visible = true;
                    lastNTextBox.Visible = true;
                    userNameLabel.Visible = true;
                    firstNLabel.Visible = true;
                    LastNLabel.Visible = true;

                DeleteInfoBTN.Visible = true;
                Presenter.OnTeacherRemove();

            }
                else if (typeOfProfile == "Ученик")
              
            {
                firstNTextBox.Visible = true;
                lastNTextBox.Visible = true;
                firstNLabel.Visible = true;
                LastNLabel.Visible = true;
                PINTextBox.Visible = true;
                PINLabel.Visible = true;
                checkPictureBox.Visible = true;
                
                
            }
                else if (typeOfProfile=="Родител")
            {
                comboBoxUsername.Visible = true;
                firstNTextBox.Visible = true;
                lastNTextBox.Visible = true;
                userNameLabel.Visible = true;
                firstNLabel.Visible = true;
                LastNLabel.Visible = true;
                DeleteInfoBTN.Visible = true;
                Presenter.OnParentRemove();
            }    
            else
            {
                Message("Изберете профил.", "Внимание", Views.MessageIcon.Warning);
                addBtn.Visible = true;
                deleteBtn.Visible = true;
            }



        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            firstNTextBox.Enabled = true;
            lastNTextBox.Enabled = true;
            checkBoxPassVisible.Visible = true;
            HideAll();
            ClearText();
        
             if (typeOfProfile=="Учител")
                {

                    usernameTextBox.Visible = true;
                    firstNTextBox.Visible = true;
                    lastNTextBox.Visible = true;
                    userNameLabel.Visible = true;
                    firstNLabel.Visible = true;
                    LastNLabel.Visible = true;
                    subject1gradeLabel.Visible = true;
                    subject1gradeLabel.Text = "Предмет:";
                    subjectTextBox.Visible = true;
                    passwordLabel.Visible = true;
                    passwordTextBox.Visible = true;
                    AddInfoBTN.Visible = true;
                   checkBoxPassVisible.Visible = true;

            }
                else if (typeOfProfile == "Ученик")
                {
                firstNTextBox.Visible = true;
                lastNTextBox.Visible = true;
                firstNLabel.Visible = true;
                LastNLabel.Visible = true;
                subject1gradeLabel.Visible = true;
                subject1gradeLabel.Text = "Клас:";
                comboBoxGrade.Visible = true;
                PINLabel.Visible = true;
                PINTextBox.Visible = true;
                studentNumberLabel.Visible = true;
                studentNumberTextBox.Visible = true;
                AddInfoBTN.Visible = true;
            }
           else if (typeOfProfile=="Родител")
            {
                Message("Не можете да добавяте профил на родител.", "Внимание", Views.MessageIcon.Warning);
                ClearText();
                addBtn.Visible = true;
                deleteBtn.Visible = true;
            }    
            else
            {
                Message("Изберете профил.", "Внимание", Views.MessageIcon.Warning);
                addBtn.Visible = true;
                deleteBtn.Visible = true;
            }



        }

        private void AddInfoBTN_Click(object sender, EventArgs e)
        {
            Presenter.OnSaveClick();
           // ClearText();
            comboBoxGrade.SelectedIndex = -1;


        }

        private void DeleteInfoBTN_Click(object sender, EventArgs e)
        {
 
                Presenter.OnRemoveClick();
                ClearText();
            if (typeOfProfile == "Родител")
            {
                Presenter.OnParentRemove();
            }
            else
            {
                Presenter.OnTeacherRemove();
            }
           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClick();
        }

        private void comboBoxUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearText();
           
            if(typeOfProfile=="Учител")
            {
                Presenter.OnTeacherSelection();
            }
            else
            {
                Presenter.OnParentSelection();
            } 

        }

  

        private void comboBoxProfile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HideAll();
            ClearText();
            addBtn.Visible = true;
            deleteBtn.Visible = true;
        }

        private void checkPictureBox_Click(object sender, EventArgs e)
        {
            Presenter.OnStudentSelection();
           
        }

        private void checkBoxPassVisible_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnPasswordVisibleCheckBoxChange();
        }

        private void firstNTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip_name_tbox.Show("Въведете име на кирилица!" , firstNTextBox);
        }

        private void lastNTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip_sn_tb.Show("Въведете фамилия на кирилица!", lastNTextBox);
        }

        private void usernameTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip_username.Show("Въведете потребителското име с латински символи!", usernameTextBox);
        }
    }
}
