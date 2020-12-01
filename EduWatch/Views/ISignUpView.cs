﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface ISignUpView : IView
    {
        Presenters.SignUpPresenter Presenter { set; }

        string Username { get; }
        string Pass { get; }
        string FirstName { get; }
        string Surname { get; }
        
    }
}
