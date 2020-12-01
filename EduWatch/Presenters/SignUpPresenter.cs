using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

            // Load entities into local cache
            data.Parents.LoadAsync();
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

            Utilities.IPasswordHash passHasher = new Utilities.PasswordHash();
            var passHash = passHasher.Generate(view.Pass);

            var newParent = new Model.Parent() { parent_firstN = view.FirstName, parent_lastN = view.Surname, username = view.Username, password_hash = passHash };
            data.Parents.Add(newParent);

            try
            {
                data.SaveChanges();
            }
            catch (Exception)
            {
                view.Message("В момента изпитваме технически затруднения. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            view.Message("Вашият профил беше създаден успешно. Можете да го използвате.", "Успех", Views.MessageIcon.Information);
            view.Close();
            loginPresenter.ShowLoginView();
        }
    }
}
