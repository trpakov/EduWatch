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
        string SubjectTextBox { get; set; }
        string ComboBoxGrade { get; set; }
        string PINTextBox { get; set; }
        int ComboBoxSubjectSelectedIndex { get; set; }
        int ComboBoxUserNameSelectedIndex { get; set; }
        int SelectedSubjectID { get; }
        int SelectedUserNameID { get; }
        string typeOfProfile { get;}
        bool isbtnDeleteVisible { get; }
        bool isbtnAddVisible { get; }
        bool isUserNameTextBoxVisible { get; }
        bool isUserNameComboBoxVisible { get; }
        bool isPINTextBoxVisible { get; }
        bool isSubjectComboBoxVisible { get; }
        bool isSubjectTextBoxVisible { get; }
        bool isBTNAddisible { get; }
        bool isBTNDeleteVisible { get; }
        bool isFirstNTextBoxVisible { get; }
        bool isLastNTextBoxVisible { get; }
        bool isSubjectGradeLabelVisible { get; }
        bool isPINSubjectLabelVisible { get; }

        void FillInProfile(string[] typeOfProfiles);
        void FillInWhichGrade(string[] grade);

        void FIllInCorrespondingSubjects(List<Tuple<int, string>> subjects);
        void FillInCorrespondingUserNames(List<Tuple<int, string>> usernames);
        void AddTeacher();
        void AddStudent();
        void DeleteTeacher();
        void DeleteStudent();
        void DeleteParent();
        void AdminStartView();
 


    }
}
