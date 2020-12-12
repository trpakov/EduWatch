using EduWatch.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface IAdminView : IView
    {
        Presenters.AdminPresenter Presenter { set; }
        string AdminLabelText { get; set; }
        string ComboBoxProfile { get; set; }      
        string FirstNTextBox { get; set; }
        string LastNTextBox { get; set; }
        string UserNameTextBox { get; set; }
        string ComboBoxUserName { get; set; }
        string TextBoxSubject { get; set; }
        string ComboBoxGrade { get; set; }
        string PINTextBox { get; set; }
        string PasswordTextBox { get; set; }
        int ComboBoxUserNameSelectedIndex { get; set; }
        string StudentNumberTextBox { get; set; }
        int SelectedUserNameID { get; }
        string typeOfProfile { get;}
        bool isbtnDeleteVisible { get; }
        bool isbtnAddVisible { get; }
        bool isUserNameTextBoxVisible { get; }
        bool isUserNameComboBoxVisible { get; }
        bool isPINTextBoxVisible { get; }
        bool isBTNAddisible { get; }
        bool isBTNDeleteVisible { get; }
        bool isFirstNTextBoxVisible { get; }
        bool isLastNTextBoxVisible { get; }
        bool isSubjectGradeLabelVisible { get; }
        bool isStudentNumberTextBoxVisivle { get; }
        bool isStudentNumberLabelVisible { get; }
        bool isPINLabelVisible { get; }
        bool isPasswordTextBoxVisible { get; }
        bool isPasswordLabelVisible { get; }
        bool isCheckBtnVisible { get; }
        bool isSubjectTextBoxVisible { get; }


        void FillInProfile(string[] typeOfProfiles);
        void FillInWhichGrade(string[] grade);
        void FillInCorrespondingUserNames(string[] usernames);

        void AdminStartView();


    }
}
