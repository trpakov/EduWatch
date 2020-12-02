using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduWatch.Presenters;

namespace EduWatch.Views
{
    public partial class EditForm : Form, IEditView
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public IEditPresenter Presenter { private get; set; }

        public void DisplayAddStudentScreem()
        {
            throw new NotImplementedException();
        }

        public void DisplayChangeNameScreem()
        {
            throw new NotImplementedException();
        }

        public void DisplayChangePassScreen()
        {
            throw new NotImplementedException();
        }

        public void DisplayMainScreen()
        {
            throw new NotImplementedException();
        }

        public void Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            MessageBox.Show(
                msg,
                caption,
                (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                );
        }

        private void goBackPic_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowAsModal()
        {
            ShowDialog();
        }

        /*В  зависимост от това кой бутон е натиснат ще се визуализират текстбоксовете със съответстващите им лейбъли като 
         като при тийчър формата ше се показва  бутона за име и бутона за промяна на парола, а при родителската форма ще се показва и бутона за 
        добавяне на ученик имаме пикчър бокс за връщане назад, като ако не са цъкнати бутоните се връща към родителската/учителската форма,
        ако е цъкнат бутон се връща назад към главните три бутона*/
    }
}
