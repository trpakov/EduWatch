using EduWatch.Model;
using EduWatch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        Views.IAdminView view;

        Model.SchoolDBEntities data;

        Model.IUser user;
        
       IAdminPresenter adminPresenter;

       ILoginPresenter loginPresenter;

        public AdminPresenter(Views.IAdminView view, Model.SchoolDBEntities data, Model.IUser user, IAdminPresenter adminPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
            this.adminPresenter = adminPresenter;

            var admin = user as Model.Admin;
            view.AdminLabelText = admin.admin_firstN + ' ' + admin.admin_lastN;

        }
        public void Start() => view.Show();

        public void OnExitButtonClick()
        {
            loginPresenter.ShowLoginView();
        }
    }
    
}
