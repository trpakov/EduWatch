using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduWatch.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        // Associated view
        Views.ILoginView view;
        // Associated data model
        Model.SchoolDBEntities data;

        public LoginPresenter(Views.ILoginView view, Model.SchoolDBEntities data)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;

            // Shows the user what types of accounts are available so they can choose accordingly.
            view.FillInTypesOfUsers(new string[]{ "Учител", "Родител"});
        }

        // Alternative constructors
        public LoginPresenter() : this(new Views.LoginForm(), new Model.SchoolDBEntities()) { }
        public LoginPresenter(Model.SchoolDBEntities data) : this(new Views.LoginForm(), data) { }

        public void OnLoginButtonClick()
        {
            // Check if the user input is valid, display info if not.
            if (view.Username == string.Empty)
            {
                view.Message("Моля, въведете вашето потребителско име.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (view.Pass == string.Empty)
            {
                view.Message("Моля, въведете вашата парола.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            // Check what type the user belongs to and query the corresponding table in the dabase with the given username
            Model.IUser currentUser = null;
            string typeOfUser = view.TypeOfUser;
            switch (typeOfUser)
            {
                case null:
                    view.Message("Моля, посочете какъв потребител сте.", "Внимание", Views.MessageIcon.Warning);
                    view.ShowAvailableUserTypes();
                    return;
                case "Учител":
                    currentUser = data.Teachers.Where(x => x.username == view.Username).SingleOrDefault();
                    break;
                case "Родител":
                    currentUser = data.Parents.Where(x => x.username == view.Username).SingleOrDefault();
                    break;
            }

            // Display error message if there is no such user.
            if(currentUser == null)
            {
                view.Message("Грешно потребителско име и/или парола. Моля, опитайте отново. Ако продължавате да изпитвате затруднения, свържете се с училищния администратор.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            // Instantiate a new password hashing/checking class and use it to check if the user password is correct.
            Utilities.IPasswordHash passHashChecker = new Utilities.PasswordHash();
            var isPasswordCorrect = passHashChecker.Verify(view.Pass, currentUser.Password);

            // Disaply error if password is not correct
            if (!isPasswordCorrect)
            {
                view.Message("Грешно потребителско име и/или парола. Моля, опитайте отново.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            // If everything is fine, hide this view and start the appropriate one. (Not implemented)
            view.Hide();
            //view.Close();

            switch (currentUser.UserType)
            {
                case Model.UserType.Teacher:
                    Views.ITeacherView teacherView = view.CreateTeacherView();
                    ITeacherPresenter teacherPresenter = PresenterFactory.GetTeacherPresenter(teacherView, data, currentUser, this);
                    teacherPresenter.Start();
                    break;
                case Model.UserType.Parent:
                    Views.IParentView parentView = view.CreateParentView();
                    IParentPresenter parentPresenter = PresenterFactory.GetParentPresenter(parentView, data, currentUser, this);
                    parentPresenter.Start();
                    break;
            }
        }

        public void OnExitButtonClick()
        {
            // Close the login view, which in turn exits the application.
            view.Close();
            // Dispose of dbcontext object
            data.Dispose();
        }

        public void ShowLoginView()
        {
            view.Show();
        }
    }

}