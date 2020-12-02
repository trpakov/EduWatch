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

        bool MainDisplayVisible { get; }

        void DisplayMainScreen();
        void DisplayChangeNameScreen();
        void DisplayChangePassScreen();
        void DisplayAddStudentScreen();
        void ShowAsModal();
    }
}
