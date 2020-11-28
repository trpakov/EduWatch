using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public interface ILoginPresenter
    {
        void OnLoginButtonClick();
        void OnExitButtonClick();
        void ShowLoginView();
        void Start();
    }
}
