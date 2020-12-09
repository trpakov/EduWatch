using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public interface ISignUpPresenter
    {
        void Start();
        void OnCancelButtonClick();
        void OnCreateButtonClick();
        void OnPasswordVisibleCheckBoxChange();
    }
}