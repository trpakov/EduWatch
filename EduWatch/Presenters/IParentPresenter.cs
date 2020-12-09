using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public interface IParentPresenter
    {
        void Start();
        void OnExitButtonClick();
        void OnStudentSelection();
        void OnGradesButtonClick();
        void OnSubjectSelection();
        void OnAverageGradeButtonClick();
        void OnSettingsButtonClick();
    }
}
