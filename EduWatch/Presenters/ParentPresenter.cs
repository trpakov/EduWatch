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
        // Data to be sent to the view
        object dataForGridView;
        // Current subject selected by the user
        Model.Subject currentSubject;
        // Grades of selected student for selected subject
        List<Model.Grade> currentGrades;
        // Notes of selected student for selected subject
        List<Model.Note> currentNotes;

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
            SaveChanges();
            view.Close();
            loginPresenter.ShowLoginView();
        }

        public void OnStudentSelection()
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
            view.GradesRadioButtonEnabledState = false;
            view.NotesRadioButtonEnabledState = false;
            view.AverageGradeButtonEnabled = false;
            view.ClearData();
        }

        public void OnGradesButtonClick()
        {
            SaveChanges(true);
            PrepareDataForView();
            if (view.SelectedGradesView) view.AverageGradeButtonEnabled = true; else view.AverageGradeButtonEnabled = false;
        }

        public void OnSubjectSelection()
        {
            // Get selected subject
            currentSubject = data.Subjects.Where(x => x.subject_id == view.SelectedSubjectID).Single();
            PrepareDataForView();

            view.GradesRadioButtonEnabledState = true;
            view.NotesRadioButtonEnabledState = true;
            if (view.SelectedGradesView) view.AverageGradeButtonEnabled = true;
        }

        void PrepareDataForView()
        {
            if (view.SelectedGradesView)
            {
                // Get all grades of the selected student for the selected subject
                currentGrades = currentSubject.Grades.Where(x => x.student_id == view.SelectedStudentID).ToList();
                var dataForGridViewList = currentGrades.Select(x => new Views.GradeViewData { ID = x.grade_id, Grade = x.grade1, Seen = x.grade_seen, Comment = x.comment, Date = x.date.ToLongDateString() }).ToList();
                dataForGridView = new Utilities.SortableBindingList<Views.GradeViewData>(dataForGridViewList);
            }
            else
            {
                // Get all notes of the selected student for the selected subject
                currentNotes = currentSubject.Notes.Where(x => x.student_id == view.SelectedStudentID).ToList();
                var dataForGridViewList = currentNotes.Select(x => new Views.NoteViewData { ID = x.note_Id, Note = x.note1, Seen = x.note_seen, Date = x.note_date.ToLongDateString() }).ToList();
                dataForGridView = new Utilities.SortableBindingList<Views.NoteViewData>(dataForGridViewList);
            }

            // Send the data to the view and display it
            view.GridViewData = dataForGridView;
            view.FormatDataDisplay();
        }

        public void OnAverageGradeButtonClick()
        {
            view.AverageGradeText = currentGrades.Average(x => x.grade1).ToString();
        }


        public void SaveChanges(bool isSavingOnDataViewChange = false)
        {
            if (currentNotes == null && currentGrades == null) return;

            // Propagate the changes to the entity objects tracked by DbContext instance and commit them to the database
            if (view.SelectedGradesView ^ isSavingOnDataViewChange)
            {
                var gradesWithChangedSeenStatus = currentGrades.Where(x => x.grade_seen != (dataForGridView as IEnumerable<Views.GradeViewData>).Where(y => y.ID == x.grade_id).Single().Seen).ToList();
                foreach (var grade in gradesWithChangedSeenStatus)
                    grade.grade_seen = !grade.grade_seen;
            }
            else
            {
                var notesWithChangedSeenStatus = currentNotes.Where(x => x.note_seen != (dataForGridView as IEnumerable<Views.NoteViewData>).Where(y => y.ID == x.note_Id).Single().Seen).ToList();
                foreach (var note in notesWithChangedSeenStatus)
                    note.note_seen = !note.note_seen;
            }

            try
            {
                data.SaveChanges();
                //throw new Exception();
            }
            catch (Exception)
            {
                if(!isSavingOnDataViewChange)
                    view.Message("В момента изпитваме технически затруднения. Възможно е вашите промени да не са запазени. Моля, опитайте отново по-късно. Съжаляваме за причененото неудобство.", "Грешка", Views.MessageIcon.Error);
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
            view.ParentNameLabelText = user.FirstName + ' ' + user.LastName;

            var students = (user as Model.Parent).Students.Select(x => Tuple.Create(x.student_id, x.student_firstN + ' ' + x.student_lastN));
            view.FillInCorrespondingStudents(students.ToList());
            view.ComboBoxStudentSelectedIndex = -1;
            view.ComboboxSubjectSelectedIndex = -1;
            view.ComboBoxSubjectEnabled = false;
            view.GradesRadioButtonEnabledState = false;
            view.NotesRadioButtonEnabledState = false;
            view.AverageGradeButtonEnabled = false;
            view.ClearData();
        }
    }
}
