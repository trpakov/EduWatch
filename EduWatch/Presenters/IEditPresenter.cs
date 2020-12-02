using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public interface IEditPresenter
    {
        void Start();
        void OnChangeNamesButtonClick();
        void OnChangePassButtonClick();
        void OnAddStudentButtonClick();
        void OnBackButtonClick();
        void OnSaveNameChangesButtonClick();
    }
}
