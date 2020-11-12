using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void Start() => view.Show();

        public void OnExitButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }
    }
}
