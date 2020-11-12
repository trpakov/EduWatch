using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Views
{
    public interface IParentView : IView
    {
        Presenters.ParentPresenter Presenter { set; }
    }
}
