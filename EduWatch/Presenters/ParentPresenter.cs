using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EduWatch.Presenters
{
    public class ParentPresenter : IParentPresenter
    {
        // Associated view
        Views.IParentView view;
        // Associated data model
        Model.SchoolDBEntities data;
        // Current user
        Model.IUser user;
        // Login presenter
        ILoginPresenter loginPresenter;

        public ParentPresenter(Views.IParentView view, Model.SchoolDBEntities data, Model.IUser user, ILoginPresenter loginPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
            this.loginPresenter = loginPresenter;

            // View initialization
            var parent = user as Model.Parent;
            view.ParentNameLabelText = parent.parent_firstN + ' ' + parent.parent_lastN;

            // Get all studets associated with this parent and transform them into a structure that is databinded to a combobox
            var students = parent.Students.Select(x => Tuple.Create(x.student_id, x.student_firstN + ' ' + x.student_lastN));
            view.FillInCorrespondingStudents(students.ToList());
            view.ComboBoxStudentSelectedIndex = -1;
        }

        public void Start() => view.Show();

        public void OnExitButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }

        internal void OnStudentSelection()
        {
            if (view.ComboBoxStudentSelectedIndex == -1) return;

            // Get all subjects for which the student has grades.
            var subjectsWithGrades = data.Students.Where(x => x.student_id == view.SelectedStudentID).Single().Grades.Select(x => x.Subject).ToList();
            // Get all subjects for which the student has notes.
            var subjectsWithNotes = data.Students.Where(x => x.student_id == view.SelectedStudentID).Single().Notes.Select(x => x.Subject).ToList();
            // Union between the two lists to remove duplicates.
            var subjects = subjectsWithGrades.Union(subjectsWithNotes);
            // Transform subjects into a tuple for combobox databinding.
            var subjectsData = subjects.Select(x => Tuple.Create(x.subject_id, x.subject_name)).ToList();
            // Fill the combobox and enable it.
            view.FIllInCorrespondingSubjects(subjectsData);
            view.ComboboxSubjectSelectedIndex = -1;
            view.ComboBoxSubjectEnabled = true;
        }

        internal void OnGradesButtonClick()
        {
            throw new NotImplementedException();
        }

        internal void OnNotesButtonClick()
        {
            throw new NotImplementedException();
        }

        internal void OnSubjectSelection()
        {
            // Get selected subject
            var subject = data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single();
            // Get all grades of the selected student for the selected subject
            var grades = subject.Grades.Where(x => x.student_id == view.SelectedStudentID).ToList();

            // Send the data to the view and display it
            var dataForGridView = grades.Select(x => new Views.GradeViewData { ID = x.grade_id, Grade = (int)x.grade1, Seen = (bool)x.grade_seen, Comment = x.comment }).ToList();
            view.FillInCorrespondingGrades(dataForGridView);
            
        }
    }
}
