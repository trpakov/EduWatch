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
        public string ComboBoxProfile { get => comboBoxProfile.Text; set => comboBoxProfile.Text = value; }
        public string FirstNTextBox { get => firstNTextBox.Text; set => firstNTextBox.Text = value; }
        public string LastNTextBox { get => lastNTextBox.Text; set => lastNTextBox.Text = value; }
        public string UserNameTextBox { get => usernameTextBox.Text; set => usernameTextBox.Text = value; }
        public string ComboBoxUserName { get => comboBoxUsername.Text; set => comboBoxUsername.Text = value; }
        public string ComboBoxSubject { get => comboBoxSubject.Text; set => comboBoxSubject.Text = value; }
        public string SubjectTextBox { get => subjectsTextBox.Text; set => subjectsTextBox.Text = value; }
        public string ComboBoxGrade { get => comboBoxGrade.Text; set => comboBoxGrade.Text = value; }

        public string typeOfProfile => comboBoxProfile.SelectedItem?.ToString();

        public bool isbtnDeleteVisible => deleteBtn.Visible;

        public bool isbtnAddVisible => addBtn.Visible;

        public bool isUserNameTextBoxVisible => usernameTextBox.Visible;

        public bool isUserNameComboBoxVisible => comboBoxUsername.Visible;

        public bool isPINTextBoxVisible => PINTextBox.Visible;

        public bool isSubjectComboBoxVisible => comboBoxSubject.Visible;

        public bool isSubjectTextBoxVisible => subjectsTextBox.Visible;

        string IAdminView.PINTextBox { get => PINTextBox.Text; set => PINTextBox.Text = value; }

        public bool isBTNAddisible => AddInfoBTN.Visible;

        public bool isBTNDeleteVisible =>  DeleteInfoBTN.Visible;

        public bool isFirstNTextBoxVisible => firstNTextBox.Visible;

        public bool isLastNTextBoxVisible => lastNTextBox.Visible;

        public bool isSubjectGradeLabelVisible => subject1gradeLabel.Visible;

        public bool isPINSubjectLabelVisible => PIN1subjectLabel.Visible;
        public int ComboBoxSubjectSelectedIndex { get => comboBoxSubject.SelectedIndex; set => comboBoxSubject.SelectedIndex = value; }
        public int SelectedSubjectID => (int)comboBoxSubject.SelectedValue;
        
        public int ComboBoxUserNameSelectedIndex { get => comboBoxUsername.SelectedIndex; set =>comboBoxUsername.SelectedIndex=value; }

        public int SelectedUserNameID => (int)comboBoxUsername.SelectedValue;

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
            throw new NotImplementedException();
        }

        public void AdminStartView()
        {
            HideAll();
            ClearText();
            addBtn.Visible = true;
            deleteBtn.Visible = true;
            ShowDialog();
        }

        public void AddStudent()
        {
            HideAll();
            ClearText();
        }

        public void AddTeacher()
        {
            HideAll();
            ClearText();
        }

        public void DeleteParent()
        {
            HideAll();
            ClearText();
        }

        public void DeleteStudent()
        {
            HideAll();
            ClearText();
        }

        public void DeleteTeacher()
        {
            HideAll();
            ClearText();
        }

        public void HideAll()
        {
            deleteBtn.Visible = false;

            addBtn.Visible = false;

            usernameTextBox.Visible = false;

            comboBoxUsername.Visible = false;          

            PINTextBox.Visible = false;

            comboBoxSubject.Visible = false;

            subjectsTextBox.Visible = false;
           
            AddInfoBTN.Visible=false;
           
            DeleteInfoBTN.Visible=false;

            firstNTextBox.Visible = false;
            lastNTextBox.Visible = false;
            subject1gradeLabel.Visible = false;
            PIN1subjectLabel.Visible = false;
            userNameLabel.Visible = false;
            firstNLabel.Visible = false;
            LastNLabel.Visible = false;
            comboBoxGrade.Visible = false;

    }
        public void ClearText()
        {
            usernameTextBox.Text = string.Empty;

            comboBoxUsername.Text = string.Empty;

            PINTextBox.Text = string.Empty;

            comboBoxSubject.Text = string.Empty;

            subjectsTextBox.Text = string.Empty;
            firstNTextBox.Text = string.Empty;
            lastNTextBox.Text = string.Empty;


        }

        public void FIllInCorrespondingSubjects(List<Tuple<int, string>> subjects)
        {
            comboBoxSubject.DisplayMember = "Item2";
            comboBoxSubject.ValueMember = "Item1";
            comboBoxSubject.DataSource = subjects;
        }

        public void FillInCorrespondingUserNames(List<Tuple<int, string>> usernames)
        {
            comboBoxUsername.DisplayMember = "Item2";
            comboBoxUsername.ValueMember = "Item1";
            comboBoxUsername.DataSource = usernames;
        }
    }
}
