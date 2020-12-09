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
        ILoginPresenter loginPresenter;

        Model.Parent parent;
        Model.Teacher teacher;
        Model.Student student;


        public AdminPresenter(IAdminView view, SchoolDBEntities data, IUser user, ILoginPresenter loginPresenter)
        {
            this.view = view;
            view.Presenter = this;
            this.data = data;
            this.user = user;
            this.loginPresenter = loginPresenter;

            var admin = user as Model.Admin;
            view.AdminLabelText = admin.admin_firstN + ' ' + admin.admin_lastN;

            view.FillInProfile(new string[] { "Учител", "Ученик", "Родител" });
            view.FillInWhichGrade(new string[] { "8", "9", "10", "11", "12" });

        }
        public void OnDeleteProfileSelection()
        {

            //Model.IUser currentUser = null;
            string typeOfProfile = view.typeOfProfile;
           
                switch (typeOfProfile)
                {
                    case null:
                        view.Message("Моля, посочете вида потребител.", "Внимание", Views.MessageIcon.Warning);
                        return;
                    case "Учител":

                        break;
                    case "Родител":
                        break;
                    case "Ученик":

                        break;
                }
            
        }
        public void OnAddProfileSelection()
        {

        }
   
        public void Start() => view.Show();

        public void OnExitButtonClick()
        {
            view.Close();
            loginPresenter.ShowLoginView();
        }
    }
    
}
