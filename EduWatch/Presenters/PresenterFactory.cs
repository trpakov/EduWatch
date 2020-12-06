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
        public static ILoginPresenter GetLoginPresenter() => new LoginPresenter();
        public static ISignUpPresenter GetSignUpPresenter(Views.ISignUpView view, Model.SchoolDBEntities data, ILoginPresenter loginPresenter) => new SignUpPresenter(view, data, loginPresenter);
        public static IEditPresenter GetEditPresenter( Model.SchoolDBEntities data, Model.IUser currentUser) => new EditPresenter(data, currentUser);
        public static IAdminPresenter GetAdminPresenter(Views.IAdminView view, Model.SchoolDBEntities data, IAdminPresenter adminPresenter) => new AdminPresenter(view, data, adminPresenter);
    }
}
