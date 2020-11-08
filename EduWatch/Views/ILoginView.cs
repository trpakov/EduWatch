using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace EduWatch.Views
{
    public interface ILoginView
    {
        string Username { get; }
        string Pass { get; }

        Presenters.LoginPresenter Presenter { set; }

        void Hide();
        void Show();
        void Message(string msg, string caption, MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK);
   
    }

    public enum MessageIcon
    {
        None,
        Warning,
        Error,
        Exclamation,
        Information
    }

    public enum MessageButton
    {
        OK,
        OKCancel,
        YesNo,
        YesNoCancel
    }
}
