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

            view.DisplayMainScreen();
        }

        public EditPresenter(Model.SchoolDBEntities data, Model.IUser user) : this(new Views.EditForm(), data, user) { }

        public void Start() => view.ShowAsModal();

        public void OnChangeNamesButtonClick()
        {
            view.DisplayChangeNameScreen();
        }

        public void OnChangePassButtonClick()
        {

        }

        public void OnAddStudentButtonClick()
        {

        }

        public void OnBackButtonClick()
        {
            if (!view.SaveChangesButtonVisible)
                view.Close();
            else
                view.DisplayMainScreen();
        }
    }
}
