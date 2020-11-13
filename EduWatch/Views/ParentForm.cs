using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduWatch.Model;
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
        public string ParentNameLabelText { get => LblName.Text; set => LblName.Text = value; }
        public int ComboBoxStudentSelectedIndex { get => comboBoxStudent.SelectedIndex; set => comboBoxStudent.SelectedIndex = value; }
        public int SelectedStudentID => (int)comboBoxStudent.SelectedValue;
        public int ComboboxSubjectSelectedIndex { get => comboBoxSubject.SelectedIndex; set => comboBoxSubject.SelectedIndex = value; }
        public int SelectedSubjectID => (int)comboBoxSubject.SelectedValue;
        public bool ComboBoxSubjectEnabled { get => comboBoxSubject.Enabled; set => comboBoxSubject.Enabled = value; }

        public void FillInCorrespondingStudents(List<Tuple<int, string>> students)
        {
            comboBoxStudent.DisplayMember = "Item2";
            comboBoxStudent.ValueMember = "Item1";
            comboBoxStudent.DataSource = students;         
        }

        public void FIllInCorrespondingSubjects(List<Tuple<int, string>> subjects)
        {  
            
            comboBoxSubject.DisplayMember = "Item2";
            comboBoxSubject.ValueMember = "Item1";
            comboBoxSubject.DataSource = subjects;        
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

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClick();
        }

        private void comboBoxStudent_SelectionChangeCommited(object sender, EventArgs e)
        {
            Presenter.OnStudentSelection();
        }
    }
}
