using EduWatch.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduWatch.Views
{
    public partial class AdminForm : Form, IAdminView
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminPresenter Presenter { private get; set; }
        public string AdminLabelText { get => adminLabelText.Text; set => adminLabelText.Text = value; }

        public MessageResult Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            throw new NotImplementedException();
        }

        /*
         под текстбокса за потребителско име има комбо бокс,
        ако искаме изтриване на профил, да можем да изберем от съществуващи
         предмети за добавяне на профила на учител,като се добавят в текстбокса отдолу, а под него има текстбокс за егн на ученик
        ако е избран ученик лейбъла се прекръства на клас и комбобокса представлява класа от 8-12
        в зависимост това кой бутон е цъкнат в началото бутонът за промените изтрий и добави върши съответното действие
         */
    }
}
