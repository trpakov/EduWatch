using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
   public interface IAdminPresenter
    {
        void Start();
        void OnExitButtonClick();
        void OnSaveClick();
        void OnRemoveClick();
        void OnTeacherRemove();
        void OnParentRemove();
        void OnTeacherSelection();
        void OnParentSelection();
        void OnStudentSelection();
       

    }
}
