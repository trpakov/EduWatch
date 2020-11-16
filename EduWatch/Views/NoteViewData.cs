using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EduWatch.Views
{
    // Class representing Note infromation that is sent to the view to be displayed.
    class NoteViewData
    {
        [Browsable(false)]
        public int ID { get; set; }
        [DisplayName("Забележка")]
        public string Note { get; set; }
        [DisplayName("Видяна")]
        public bool Seen { get; set; }
        [DisplayName("Дата")]
        public string Date { get; set; }
    }
}
