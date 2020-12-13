using EduWatch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public class TeacherPresenter : ITeacherPresenter
    {
        Views.ITeacherView view;
        Model.SchoolDBEntities data;
        Model.IUser user;
        ILoginPresenter loginPresenter;
        object dataForGridView;
        Model.Student currentStudent;
        List<Model.Grade> currentGrades;
        List<Model.Note> currentNotes;
        public TeacherPresenter(Views.ITeacherView view, Model.SchoolDBEntities data, Model.IUser user, ILoginPresenter loginPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
            this.loginPresenter = loginPresenter;

            var teacher = user as Model.Teacher;
            view.TeacherNameLabelText = teacher.teacher_firstN + ' ' + teacher.teacher_lastN;


            var subject = teacher.Subjects.Select(x => Tuple.Create(x.subject_id, x.subject_name));
            view.FIllInCorrespondingSubjects(subject.ToList());
            view.ComboBoxSubjectSelectedIndex = -1;
            view.ComboBoxStudentSelectedIndex = -1;

            view.FillInGrades(new string[] { "6", "5", "4", "3", "2" });
            view.FillInWhichGrade(new string[] { "8", "9", "10", "11", "12" });
            
        }

        public void Start() => view.Show();

        public void OnExitButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }

        internal void OnSubjectSelection()
        {
            if (view.ComboBoxSubjectSelectedIndex == -1) return;
            var student = data.Students.Where(x=>x.grade==view.ComboBoxGrade1to12).Select(x => new { ID = x.student_id, Name = x.student_firstN + " " + x.student_lastN}).AsEnumerable().Select(x => Tuple.Create(x.ID, x.Name)).ToList();
            view.FillInCorrespondingStudents(student);
            view.ComboBoxStudentSelectedIndex = -1;
            view.ComboBoxStudentEnabled = true;
        }

        internal void OnGradesButtonClick()
        {
                PrepareDataForView();

        }

        internal void OnStudentSelection()
        {

                // Get selected student
                currentStudent = data.Students.Where(x => x.student_id == view.SelectedStudentID).Single();
                PrepareDataForView();
            
         
        }

         void PrepareDataForView()
        {
            if (view.SelectedGradesView)
            {
                // Get all grades of the selected student for the selected subject
                currentGrades = currentStudent.Grades.Where(x => x.student_id == view.SelectedStudentID).ToList();
                var dataForGridViewList = currentGrades.Select(x => new Views.GradeViewData { ID = x.grade_id, Grade = x.grade1, Seen = x.grade_seen, Comment = x.comment, Date = x.date.ToLongDateString() }).ToList();
                dataForGridView = new Utilities.SortableBindingList<Views.GradeViewData>(dataForGridViewList);
            }
            else
            {
                // Get all notes of the selected student for the selected subject
                currentNotes = currentStudent.Notes.Where(x => x.student_id == view.SelectedStudentID).ToList();
                var dataForGridViewList = currentNotes.Select(x => new Views.NoteViewData { ID = x.note_Id, Note = x.note1, Seen = x.note_seen, Date = x.note_date.ToLongDateString() }).ToList();
                dataForGridView = new Utilities.SortableBindingList<Views.NoteViewData>(dataForGridViewList);
            }

            // Send the data to the view and display it
            view.GridViewData = dataForGridView;
            view.FormatDataDisplay();

        }



        internal void OnAverageGradeButtonClick()
        {
            if (currentGrades.Count > 0)
            {
                view.AverageGradeTextBox = currentGrades.Average(x => x.grade1).ToString();
            }
            else
            {
                view.Message("Ученикът няма оценки по избрания предмет.", "Грешка", Views.MessageIcon.Error);
            }
        }

        internal void OnSaveNoteButtonClick()
        {
            if (view.TextBoxComment != string.Empty)
            {
                var note = new Model.Note() { note1 = view.TextBoxComment, note_date = DateTime.Now, note_seen = false, student_id = view.SelectedStudentID, subject_id = view.SelectedSubjectID };
                data.Notes.Add(note);
                data.SaveChanges();
            }
            else
            {
                view.Message("Не можете да добавите празна забележка.", "Грешка", Views.MessageIcon.Error);
            }
        }
        internal void OnSaveGradeButtonClick()
        {
            if (view.TextBoxComment != string.Empty && view.ComboBoxGrade != string.Empty)
            {
                var grade = new Model.Grade() { grade1 = int.Parse(view.ComboBoxGrade), grade_seen = false, comment = view.TextBoxComment, student_id = view.SelectedStudentID, subject_Id = view.SelectedSubjectID, date = DateTime.Now };
                data.Grades.Add(grade);
                data.SaveChanges();
            }
            else
            {
                view.Message("Моля, попълнете полетата.", "Грешка", Views.MessageIcon.Error);
            }
        }
        public void OnSettingsButtonClick()
        {
            view.Hide();
            IEditPresenter editPresenter = PresenterFactory.GetEditPresenter(data, user);
            editPresenter.Start();
            view.Show();
            ResetViewAfterUserChangesTheirProfile();

        }

        void ResetViewAfterUserChangesTheirProfile()
        {
            view.TeacherNameLabelText= user.FirstName + ' ' + user.LastName;
            view.ComboBoxStudentSelectedIndex = -1;
            view.ComboBoxSubjectSelectedIndex = -1;
            view.gradeRadioBtnEnabled = false;
            view.noteRadioBtnEnabled = false;
            view.HideAll();
        }

    }
}
