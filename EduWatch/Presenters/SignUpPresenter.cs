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

        internal void OnPasswordVisibleCheckBoxChange()
        {
            view.PasswordChar = view.PasswordChar == '*' ? '\0' : '*';
        }

        internal void OnCreateButtonClick()
        {
            if(view.Username == string.Empty)
            {
                view.Message("Моля, въведете потребителско име.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (view.Pass == string.Empty)
            {
                view.Message("Моля, въведете парола.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (view.FirstName == string.Empty || view.Surname == string.Empty)
            {
                view.Message("Моля, въведете вашето лично име и фамилия.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            var existingParent = data.Parents.Where(x => x.username == view.Username).SingleOrDefault();

            if (existingParent != null)
            {
                view.Message("Това потребителско име вече е заето. Моля, изберете друго.", "Внимание", Views.MessageIcon.Warning);
                return;
            }
        }
    }
}
