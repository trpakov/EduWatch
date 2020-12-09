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
        public string ComboBoxProfile { get => comboBoxProfile.Text; set => comboBoxProfile.Text = value; }
        public string FirstNTextBox { get => firstNTextBox.Text; set => firstNTextBox.Text = value; }
        public string LastNTextBox { get => lastNTextBox.Text; set => lastNTextBox.Text = value; }
        public string UserNameTextBox { get => usernameTextBox.Text; set => usernameTextBox.Text = value; }
        public string ComboBoxUserName { get => comboBoxUsername.Text; set => comboBoxUsername.Text=value; }
        public string ComboBoxSubject {get=> comboBoxSubject.Text ; set => comboBoxSubject.Text=value; }
        public string SubjectTextBox { get => subjectsTextBox.Text; set => subjectsTextBox.Text=value; }
        public string ComboBoxGrade { get => comboBoxGrade.Text;  set => comboBoxGrade.Text=value; }
        string IAdminView.PINTextBox { get => PINTextBox.Text; set => PINTextBox.Text=value; }

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
