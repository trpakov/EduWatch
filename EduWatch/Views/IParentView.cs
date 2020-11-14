using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface IParentView : IView
    {
        Presenters.ParentPresenter Presenter { set; }
        string ParentNameLabelText { get; set; }
        int ComboBoxStudentSelectedIndex { get; set; }
        int ComboboxSubjectSelectedIndex { get; set; }
        int SelectedStudentID { get; }
        int SelectedSubjectID { get; }
        bool ComboBoxSubjectEnabled { get; set; }
        object GridViewData { get; }

        void FillInCorrespondingStudents(List<Tuple<int, string>> students);
        void FIllInCorrespondingSubjects(List<Tuple<int, string>> subjects);
        void FillInCorrespondingGrades(object grades);
    }
}
