using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface ILoginView
    {
        string Username { get; }
        string Pass { get; }
        string TypeOfUser { get; }

        Presenters.ILoginPresenter Presenter { set; }

        void Hide();
        void Show();
        void Close();
        void Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK);

        void FillInTypesOfUsers(string[] typesOfUsers);
        void ShowAvailableUserTypes();
   
    }

    // Universal enum with Message icons
    public enum MessageIcon
    {
        None,
        Warning,
        Error,
        Exclamation,
        Information
    }

    // Universal enum with Message buttons
    public enum MessageButton
    {
        OK,
        OKCancel,
        YesNo,
        YesNoCancel
    }
}
