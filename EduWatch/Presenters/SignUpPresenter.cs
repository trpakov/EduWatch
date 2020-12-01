using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public class SignUpPresenter : ISignUpPresenter
    {
        // Associated view
        Views.ISignUpView view;
        // Associated data model
        Model.SchoolDBEntities data;
        // Login presenter
        ILoginPresenter loginPresenter;

        public SignUpPresenter(Views.ISignUpView view, Model.SchoolDBEntities data, ILoginPresenter loginPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.loginPresenter = loginPresenter;

        }

        public void OnCancelButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }

        public void Start() => view.Show();
    }
}
