using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduWatch.Presenters
{
    public class LoginPresenter
    {
        // Associated view
        Views.ILoginView view;
        // Associated data model
        Model.SchoolDBEntities data;

        public LoginPresenter(Views.ILoginView view, Model.SchoolDBEntities data)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
        }

    }
}