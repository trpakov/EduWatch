using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text.RegularExpressions;

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

        public void OnPasswordVisibleCheckBoxChange()
        {
            view.PasswordChar = view.PasswordChar == '*' ? '\0' : '*';
        }

        public void OnCreateButtonClick()
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

            if (!Regex.IsMatch(view.FirstName, @"^[А-я]+$") || !Regex.IsMatch(view.Surname, @"^[А-я]+$"))
            {
                view.Message("Моля, използвайте само букви от българската азбука за вашето собствено име и фамилия.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(view.Username, @"^[A-Za-z0-9_]+$"))
            {
                view.Message("Моля, въведете валидно потребтилеско име (разрешени са буквите от английската азбука, цифрите 0-9 и долна черта).", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            var existingParent = data.Parents.Where(x => x.username == view.Username).SingleOrDefault();
            var existingTeacher = data.Teachers.Where(x => x.username == view.Username).SingleOrDefault();
            var existingAdmin = data.Admins.Where(x => x.admin_username == view.Username).SingleOrDefault();

            if (existingParent != null || existingTeacher != null || existingAdmin != null)
            {
                view.Message("Това потребителско име вече е заето. Моля, изберете друго.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(view.Pass, @"^.{8,25}$"))
            {
                view.Message("Моля, въведете парола с дължина между 8 и 25 символа.", "Внимание", Views.MessageIcon.Warning);
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
