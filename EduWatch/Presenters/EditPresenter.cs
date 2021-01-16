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

            if (user is Model.Teacher) view.AddStudentButtonVisible = false;

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
                if (view.FirstNameTextBoxText != user.FirstName || view.LastNameTextBoxText != user.LastName)
                {
                    Views.MessageResult result = view.Message("Направените промени щe бъдат изгубени. Искате ли да продължите?", "Внимание", Views.MessageIcon.Warning, Views.MessageButton.YesNo);

                    if (result == Views.MessageResult.Yes)
                        view.DisplayMainScreen();
                    else return;
                }
                view.DisplayMainScreen();
            }
            else view.DisplayMainScreen();
        }

        public void OnSaveNameChangesButtonClick()
        {
            if(view.FirstNameTextBoxText == string.Empty || view.LastNameTextBoxText == string.Empty)
            {
                view.Message("Моля, въведето ново лично и фамилно име.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(view.FirstNameTextBoxText, @"^[А-я]+$") || !Regex.IsMatch(view.LastNameTextBoxText, @"^[А-я]+$"))
            {
                view.Message("Моля, използвайте само букви от българската азбука за вашето собствено име и фамилия.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            user.FirstName = view.FirstNameTextBoxText;
            user.LastName = view.LastNameTextBoxText;

            try
            {
                data.SaveChanges();
                view.Message("Промените бяха запазени успешно.", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {
               
                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }

            view.DisplayMainScreen();
        }

        public void OnSavePassChangesButtonClick()
        {
            if(view.OldPassTextBoxText == string.Empty || view.NewPassTextBoxText == string.Empty || view.NewPassAgainTextBoxText == string.Empty)
            {
                view.Message("Моля, попълнате всички полета.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            Utilities.IPasswordHash passHasher = new Utilities.PasswordHash();

            if(!passHasher.Verify(view.OldPassTextBoxText, user.Password))
            {
                view.Message("Въвели сте грешна парола. Моля, опитайте отново.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if(view.NewPassAgainTextBoxText != view.NewPassTextBoxText)
            {
                view.Message("Новата парола се различава от нейното потвърждение. Моля, опитайте отново.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (view.NewPassTextBoxText == view.OldPassTextBoxText)
            {
                view.Message("Новата парола не може да е същата като старата. Моля, опитайте отново.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(view.NewPassTextBoxText, @"^.{8,25}$"))
            {
                view.Message("Новата парола трябва да е с дължина между 8 и 25 символа.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            user.Password = passHasher.Generate(view.NewPassAgainTextBoxText);

            try
            {
                data.SaveChanges();
                view.Message("Паролата беше променена успешно.", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {
                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }

            view.DisplayMainScreen();
        }

        public void OnSaveStudentButtonClick()
        {
            if(!Regex.IsMatch(view.StudentPinTextBoxText, @"^\d{10}$"))
            {
                view.Message("Моля, въведете валиден единен граждански номер.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            if(view.StudentCodeTextBoxText == string.Empty)
            {
                view.Message("Моля, въведете секретен ключ.", "Внимание", Views.MessageIcon.Warning);
                return;
            }

            var targetStudent = data.Students.Where(x => x.student_PIN == view.StudentPinTextBoxText).SingleOrDefault();

            if(targetStudent == null)
            {
                view.Message("В системата не съществува ученик с това ЕГН.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            if (targetStudent.Parent != null)
            {
                view.Message("Този ученик вече е свързан със своя родител.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            if (targetStudent.code != view.StudentCodeTextBoxText)
            {
                view.Message("Въвъденият секретен ключ е невалиден.", "Грешка", Views.MessageIcon.Error);
                return;
            }

            targetStudent.Parent = user as Model.Parent;

            try
            {
                data.SaveChanges();
                view.Message("Ученикът е добавен към вашия профил. Вече може да следите неговия успех.", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {
                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }

            view.DisplayMainScreen();
        }
    }
}
