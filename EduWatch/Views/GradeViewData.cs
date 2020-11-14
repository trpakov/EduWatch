using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EduWatch.Views
{
    // Class representing Grade infromation that is sent to the view to be displayed.
    public class GradeViewData
    {
        [Browsable(false)]
        public int ID { get; set; }
        [DisplayName("Оценка")]
        public int Grade { get; set; }
        [DisplayName("Видяна")]
        public bool Seen { get; set; }
        [DisplayName("Коментар")]
        public string Comment { get; set; }
    }
}
