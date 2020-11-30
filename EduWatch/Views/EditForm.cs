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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        /*В  зависимост от това кой бутон е натиснат ще се визуализират текстбоксовете със съответстващите им лейбъли като 
         като при тийчър формата ше се показва  бутона за име и бутона за промяна на парола, а при родителската форма ще се показва и бутона за 
        добавяне на ученик имаме пикчър бокс за връщане назад, като ако не са цъкнати бутоните се връща към родителската/учителската форма,
        ако е цъкнат бутон се връща назад към главните три бутона*/
    }
}
