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
        string ComboBoxSubject { get; set; }
        string ComboBoxGrade { get; set; }
        string PINTextBox { get; set; }
        string PasswordTextBox { get; set; }
        int ComboBoxSubjectSelectedIndex { get; set; }
        int ComboBoxUserNameSelectedIndex { get; set; }
        string StudentNumberTextBox { get; set; }
        int SelectedSubjectID { get; }
        int SelectedUserNameID { get; }
        string typeOfProfile { get;}
        bool isbtnDeleteVisible { get; }
        bool isbtnAddVisible { get; }
        bool isUserNameTextBoxVisible { get; }
        bool isUserNameComboBoxVisible { get; }
        bool isPINTextBoxVisible { get; }
        bool isSubjectComboBoxVisible { get; }
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


        void FillInProfile(string[] typeOfProfiles);
        void FillInWhichGrade(string[] grade);

        void FIllInCorrespondingSubjects(string[] subjects);
        void FillInCorrespondingUserNames(string[] usernames);

        void AdminStartView();


    }
}
