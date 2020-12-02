using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EduWatch.Presenters
{
    public class EditPresenter : IEditPresenter
    {
        // Associated view
        Views.IEditView view;
        // Associated data model
        Model.SchoolDBEntities data;
        // Current user
        Model.IUser user;

        public EditPresenter(Views.IEditView view, Model.SchoolDBEntities data, Model.IUser user)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;

            view.DisplayMainScreen();
        }

        public EditPresenter(Model.SchoolDBEntities data, Model.IUser user) : this(new Views.EditForm(), data, user) { }

        public void Start() => view.ShowAsModal();

        public void OnChangeNamesButtonClick()
        {
            view.DisplayChangeNameScreen();
            view.FirstNameTextBoxText = user.FirstName;
            view.LastNameTextBoxText = user.LastName;
            
        }

        public void OnChangePassButtonClick()
        {
            view.DisplayChangePassScreen();
        }

        public void OnAddStudentButtonClick()
        {
            view.DisplayAddStudentScreen();
        }

        public void OnBackButtonClick()
        {
            // If the user is on the main screen
            if (view.MainScreenVisible)
                view.Close();
            // If the user is on the Change name screen
            else if (view.ChangeNameScreenVisible)
            {
                // Warn the user if there are unsaved changes
                if(view.FirstNameTextBoxText != user.FirstName || view.LastNameTextBoxText != user.LastName)
                {
                    Views.MessageResult result = view.Message("Направените промени щe бъдат изгубени. Искате ли да продължите?", "Внимание", Views.MessageIcon.Warning, Views.MessageButton.YesNo);

                    if (result == Views.MessageResult.Yes)
                        view.DisplayMainScreen();
                    else return;
                }
                view.DisplayMainScreen();
            }
        }

        public void OnSaveNameChangesButtonClick()
        {
            if(view.FirstNameTextBoxText == string.Empty || view.LastNameTextBoxText == string.Empty)
            {
                view.Message("Моля, въведето ново лично и фамилно име.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            user.FirstName = view.FirstNameTextBoxText;
            user.LastName = view.LastNameTextBoxText;

            try
            {
                data.SaveChanges();
                view.Message("Промените бяха запазени успешно", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {
               
                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }

            view.DisplayMainScreen();
        }
    }
}
