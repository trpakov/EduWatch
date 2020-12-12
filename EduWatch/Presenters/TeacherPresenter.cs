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

          // var studentsWithGrades =data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single().Grades.Select(x => x.Student).ToList();
          //  var studentsWithNotes = data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single().Notes.Select(x => x.Student).ToList();
          // var students = studentsWithGrades.Union(studentsWithNotes).Where(x => x.grade == view.ComboBoxGrade1to12);
           // var studentsData = students.Select(x => Tuple.Create(x.student_id, x.student_firstN + ' ' + x.student_lastN)).ToList(); 
           var studentsData =data.Students.Where(x => x.grade == view.ComboBoxGrade1to12).Select(x=> Tuple.Create(x.student_id,x.student_firstN + ' ' + x.student_lastN)).ToList();
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
                // Get all grades of the selected student for the selected subject
                currentGrades = currentStudent.Grades.Where(x => x.student_id == view.SelectedStudentID).ToList();
                var dataForGridViewList = currentGrades.Select(x => new Views.GradeViewData { ID = x.grade_id, Grade = x.grade, Seen = x.grade_seen, Comment = x.comment, Date = x.date.ToLongDateString() }).ToList();
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
            view.AverageGradeTextBox = currentGrades.Average(x => x.grade).ToString();
        }

        internal void OnSaveNoteButtonClick()
        {
            var note =new  Model.Note() { note1 = view.TextBoxComment, note_date = DateTime.Now, note_seen = false, student_id = view.SelectedStudentID,subject_id=view.SelectedSubjectID };
            data.Notes.Add(note);
            data.SaveChanges();
        }
        internal void OnSaveGradeButtonClick()
        {
            var grade = new Model.Grade() { grade = int.Parse(view.ComboBoxGrade), grade_seen = false, comment = view.TextBoxComment, student_id = view.SelectedStudentID ,subject_Id = view.SelectedSubjectID, date = DateTime.Now };
            data.Grades.Add(grade);
            data.SaveChanges();
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
            view.AverageGradeButtonEnabled = false;
            view.ClearData();
        }

    }
}
