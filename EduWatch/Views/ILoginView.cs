using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Pass { get; }
        string TypeOfUser { get; }

        Presenters.ILoginPresenter Presenter { set; }

        void FillInTypesOfUsers(string[] typesOfUsers);
        void ShowAvailableUserTypes();
        IParentView CreateParentView();
        ITeacherView CreateTeacherView();
        void StartApplication();
   
    }

}
