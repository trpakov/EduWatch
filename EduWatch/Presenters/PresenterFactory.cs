using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public static class PresenterFactory
    {
        public static IParentPresenter GetParentPresenter(Views.IParentView view, Model.SchoolDBEntities data, Model.IUser currentUser, ILoginPresenter loginPresenter) => new ParentPresenter(view, data, currentUser, loginPresenter);
        public static ITeacherPresenter GetTeacherPresenter(Views.ITeacherView view, Model.SchoolDBEntities data, Model.IUser currentUser, ILoginPresenter loginPresenter) => new TeacherPresenter(view, data, currentUser, loginPresenter);
    }
}
