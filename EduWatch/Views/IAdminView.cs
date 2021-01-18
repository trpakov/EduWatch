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
        char PasswordTextBox { get; set; }
        int ComboBoxUserNameSelectedIndex { get; set; }
        int SelectedUserNameID { get; }
        string typeOfProfile { get;}
        string Password { get; }
        bool IsbtnDeleteVisible { get; }
        bool IsbtnAddVisible { get; }
        bool IsUserNameTextBoxVisible { get; }
        bool IsUserNameComboBoxVisible { get; }
        bool IsPINTextBoxVisible { get; }
        bool IsBTNAddisible { get; }
        bool IsBTNDeleteVisible { get; set; }
        bool IsFirstNTextBoxVisible { get; }
        bool IsLastNTextBoxVisible { get; }
        bool IsSubjectGradeLabelVisible { get; }
   
        bool IsPINLabelVisible { get; }
        bool IsPasswordTextBoxVisible { get; }
        bool IsPasswordLabelVisible { get; }
        bool IsCheckBtnVisible { get; }
        bool IsSubjectTextBoxVisible { get; }


        void FillInProfile(string[] typeOfProfiles);
        void FillInWhichGrade(string[] grade);
        void FillInCorrespondingUserNames(string[] usernames);

        void AdminStartView();
        void HideAll();
        void ClearText();


    }
}
