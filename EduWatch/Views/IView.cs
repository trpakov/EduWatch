using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    // Interface to be used with all views
    public interface IView
    {
        void Hide();
        void Show();
        void Close();
        MessageResult Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK);
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

    public enum MessageResult
    {
        OK,
        Cancel,
        Yes,
        No
    }
}
