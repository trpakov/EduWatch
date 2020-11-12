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
    public partial class ParentForm : Form, IParentView
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        public ParentPresenter Presenter { private get; set; }

        public void Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            MessageBox.Show(
                msg,
                caption,
                (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClick();
        }
    }
}
