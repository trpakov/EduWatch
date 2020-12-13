using EduWatch.Model;
using EduWatch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            var regexString = new Regex(@"^[А-я]+$");
            var regexInt = new Regex("^[0-9]+$");
            switch (typeOfProfile)
            {
                
                case "Учител":
                    if (view.UserNameTextBox != string.Empty && view.TextBoxSubject != string.Empty && view.FirstNTextBox != string.Empty
                       && view.LastNTextBox != string.Empty &&view.PasswordTextBox!=string.Empty  && regexString.IsMatch(view.FirstNTextBox) 
                            && regexString.IsMatch(view.LastNTextBox) &&regexString.IsMatch(view.TextBoxSubject))
                    {
                        var existingTeacher = data.Teachers.Where(x => x.username == view.UserNameTextBox).SingleOrDefault();

                        if (existingTeacher != null)
                        {
                            view.Message("Това потребителско име вече е заето. Моля, изберете друго.", "Внимание", Views.MessageIcon.Warning);
                            return;
                        }
                        Utilities.IPasswordHash passHasher = new Utilities.PasswordHash();
                        var passHash = passHasher.Generate(view.PasswordTextBox);
                        var teacher = new Model.Teacher() { username = view.UserNameTextBox, teacher_firstN = view.FirstNTextBox, teacher_lastN = view.LastNTextBox, password_hash = passHash };
                        data.Teachers.Add(teacher);
                        var teacherid = teacher.teacher_id;
                        var subject = new Model.Subject() { subject_name = view.TextBoxSubject, teacher_id = teacherid };
                        data.Subjects.Add(subject);
                    }
                    else
                    {
                        view.Message("Моля попълнете всички полета.", "Грешка", Views.MessageIcon.Error);
                        return;
                    }
                    break;
                case "Ученик":
                    
                    if (view.ComboBoxGrade!= null && view.FirstNTextBox != string.Empty && view.LastNTextBox != string.Empty && 
                        view.StudentNumberTextBox!=string.Empty && view.PINTextBox != string.Empty && regexInt.IsMatch(view.PINTextBox)&& regexInt.IsMatch(view.StudentNumberTextBox)
                        && regexString.IsMatch(view.FirstNTextBox) && regexString.IsMatch(view.LastNTextBox))
                    {
                        var student = new Model.Student() { student_firstN = view.FirstNTextBox, student_lastN = view.LastNTextBox, grade = view.ComboBoxGrade, student_PIN = view.PINTextBox, student_No = int.Parse(view.StudentNumberTextBox) };
                        data.Students.Add(student);
                    }
                    else
                    {
                        view.Message("Моля попълнете всички полета коректно.", "Грешка", Views.MessageIcon.Error);
                        return;
                    }

                    break;           

            }
            data.SaveChanges();
            try
            {              
               
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
                case "Учител":                
                    var teacher = data.Teachers.Where(x=>x.username==view.ComboBoxUserName).Single();
                    data.Teachers.Remove(teacher);
                    break;
                case "Ученик":                   
                        var student = data.Students.Where(x => x.student_PIN == view.PINTextBox).Single();
                        data.Students.Remove(student);                  
                    break;
                case "Родител":
                    var parent = data.Parents.Where(x => x.username == view.ComboBoxUserName).Single();
                    data.Parents.Remove(parent);
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

        public void OnParentRemove()
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
            var parent = data.Parents.Where(x => x.username == view.ComboBoxUserName).Single();
            view.FirstNTextBox = parent.parent_firstN;
            view.LastNTextBox = parent.parent_lastN;
        }

        public void OnStudentSelection()
        {
            try
            {
                if (!Regex.IsMatch(view.PINTextBox, @"^\d{10}$"))
                {
                    view.Message("Моля, въведете валидно ЕГН.", "Внимание", Views.MessageIcon.Warning);
                    return;
                }

                var student = data.Students.Where(x => x.student_PIN == view.PINTextBox).Single();
                view.FirstNTextBox = student.student_firstN;
                view.LastNTextBox = student.student_lastN;
                view.IsBTNDeleteVisible = true;
            }
            catch
            {
                view.Message("Няма ученик с такова ЕГН", "ОК", Views.MessageIcon.Information);
            }
        }
    }
    
}
