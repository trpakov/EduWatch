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

        void DisplayMainScreen();
        void DisplayChangeNameScreem();
        void DisplayChangePassScreen();
        void DisplayAddStudentScreem();
        void ShowAsModal();
    }
}
