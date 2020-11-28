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

            view.FillInGrades(new string[] { "6", "5", "4", "3", "2" });
            view.FillInWhichGrade(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            
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

            var studentsWithGrades = data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single().Grades.Select(x => x.Student).ToList();
            var studentsWithNotes = data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single().Notes.Select(x => x.Student).ToList();
            var students = studentsWithGrades.Union(studentsWithNotes);
            var studentsData = students.Select(x => Tuple.Create(x.student_id, x.student_firstN + ' ' + x.student_lastN)).ToList();
            view.FillInCorrespondingStudents(studentsData);
            view.ComboBoxStudentSelectedIndex = -1;
            view.ComboBoxStudentEnabled = true;
        }

        internal void OnGradesButtonClick()
        {
            PrepareDataForView();
            if (view.SelectedGradesView) view.AverageGradeButtonEnabled = true;
            else view.AverageGradeButtonEnabled = false;
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
                currentGrades = currentStudent.Grades.Where(x => x.subject_Id == view.SelectedSubjectID).ToList();
                dataForGridView = currentGrades.Select(x => new Views.GradeViewData { ID = x.grade_id, Grade = x.grade1, Seen = x.grade_seen, Comment = x.comment, Date = x.date.ToLongDateString() }).ToList();
            }
            else
            {
                currentNotes = currentStudent.Notes.Where(x => x.subject_id == view.SelectedSubjectID).ToList();
                dataForGridView = currentNotes.Select(x => new Views.NoteViewData { ID = x.note_Id, Note = x.note1, Seen = x.note_seen, Date = x.note_date.ToLongDateString() }).ToList();
            }

            view.GridViewData = dataForGridView;

        }



        internal void OnAverageGradeButtonClick()
        {
            view.AverageGradeLabel = currentGrades.Average(x => x.grade1).ToString();
        }

        internal void OnSaveButtonClick()
        {
       

            data.SaveChanges();
        }
      
    }
}
