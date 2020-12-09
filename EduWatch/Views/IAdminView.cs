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
        string typeOfProfile { get;}
        void FillInProfile(string[] gprofiles);
        void FillInWhichGrade(string[] grade);



    }
}
