 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface IEditView : IView
    {
        Presenters.IEditPresenter Presenter { set; }

        bool MainScreenVisible { get; }
        bool ChangeNameScreenVisible { get; }
        bool ChangePassScreenVisible { get; }
        bool AddStudentScreenVisible { get; }
        string FirstNameTextBoxText { get; set; }
        string LastNameTextBoxText { get; set; }
        string OldPassTextBoxText { get; set; }
        string NewPassTextBoxText { get; set; }
        string NewPassAgainTextBoxText { get; set; }
        bool AddStudentButtonVisible { get; set; }
        string StudentPinTextBoxText { get; set; }

        void DisplayMainScreen();
        void DisplayChangeNameScreen();
        void DisplayChangePassScreen();
        void DisplayAddStudentScreen();
        void ShowAsModal();
    }
}
