using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Presenters
{
    public class EditPresenter : IEditPresenter
    {
        // Associated view
        Views.IEditView view;
        // Associated data model
        Model.SchoolDBEntities data;
        // Current user
        Model.IUser user;

        public EditPresenter(Views.IEditView view, Model.SchoolDBEntities data, Model.IUser user)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
        }

        public void Start() => view.Show();
    }
}
