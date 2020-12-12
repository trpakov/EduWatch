using EduWatch.Model;
using EduWatch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        Views.IAdminView view;

        Model.SchoolDBEntities data;

        Model.IUser user;
        ILoginPresenter loginPresenter;



        public AdminPresenter(IAdminView view, SchoolDBEntities data, IUser user, ILoginPresenter loginPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
            this.loginPresenter = loginPresenter;

            var admin = user as Model.Admin;
            view.AdminLabelText = admin.admin_firstN + ' ' + admin.admin_lastN;

            view.FillInProfile(new string[] { "Учител", "Ученик", "Родител" });
            view.FillInWhichGrade(new string[] { "8", "9", "10", "11", "12" });
            view.FIllInCorrespondingSubjects(new string[] { "Математика", "География", "История", "Физическо възпитание и спорт", "Биология", "Химия" });

        }
        public void Start() => view.AdminStartView();

        public void OnExitButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }

        public void OnSaveClick()
        {
            string typeOfProfile = view.typeOfProfile;
            switch (typeOfProfile)
            {
                case null:
                    view.Message("Моля, посочете вида потребител.", "Внимание", Views.MessageIcon.Warning);
                    return;
                case "Учител":
                    Utilities.IPasswordHash passHasher = new Utilities.PasswordHash();
                    var passHash = passHasher.Generate(view.PasswordTextBox);            
                    var teacher = new Model.Teacher() { username = view.UserNameTextBox, teacher_firstN = view.FirstNTextBox, teacher_lastN = view.LastNTextBox, password_hash = passHash };
                    data.Teachers.Add(teacher);

                    break;
                case "Учeник":
                   var student = new Model.Student() {student_firstN=view.FirstNTextBox,student_lastN=view.LastNTextBox,grade=view.ComboBoxGrade, student_PIN=view.PasswordTextBox ,student_No=int.Parse(view.StudentNumberTextBox)};
                    data.Students.Add(student);
                    break;           

            }
            try
            {              
                data.SaveChanges();
                view.Message("Промените бяха запазени успешно.", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {

                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }
        
        }

        public void OnRemoveClick()
        {
            string typeOfProfile = view.typeOfProfile;

            switch (typeOfProfile)
            {
                case null:
                    view.Message("Моля, посочете вида потребител.", "Внимание", Views.MessageIcon.Warning);
                    return;
                case "Учитeл":
              
                  
                    var teacher = data.Teachers.Where(x=>x.username==view.ComboBoxUserName).Single();
                    data.Teachers.Remove(teacher);
                    break;
                case "Ученик":
                    var student = new Model.Student() { student_PIN = view.PINTextBox };
                    data.Students.Remove(student);
                    break;
                case "Родител":
                    var parent = new Model.Parent() { username = view.UserNameTextBox };
                    break;

            }
            try
            {

                data.SaveChanges();
                view.Message("Промените бяха запазени успешно.", "Успех", Views.MessageIcon.Information);
            }
            catch (Exception)
            {

                view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
            }

        }
        public void OnTeacherRemove()
        {
            var selectedColumn = data.Teachers.Select(x => x.username);
            view.FillInCorrespondingUserNames(selectedColumn.ToArray());
            view.ComboBoxUserNameSelectedIndex = -1;

        }

        public void OnParentAdd()
        {
            var selectedColumn = data.Parents.Select(x => x.username);
            view.FillInCorrespondingUserNames(selectedColumn.ToArray());
            view.ComboBoxUserNameSelectedIndex = -1;
        }

        public void OnTeacherSelection()
        {
            var teacher =data.Teachers.Where(x => x.username == view.ComboBoxUserName).Single();
            view.FirstNTextBox = teacher.teacher_firstN;
            view.LastNTextBox = teacher.teacher_lastN;
        }

        public void OnParentSelection()
        {
            throw new NotImplementedException();
        }

        public void OnStudentSelection()
        {
            throw new NotImplementedException();
        }
    }
    
}
