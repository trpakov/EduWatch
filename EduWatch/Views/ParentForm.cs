﻿using System;
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

        public IParentPresenter Presenter { private get; set; }
        public string ParentNameLabelText { get => LblName.Text; set => LblName.Text = value; }
        public int ComboBoxStudentSelectedIndex { get => comboBoxStudent.SelectedIndex; set => comboBoxStudent.SelectedIndex = value; }
        public int SelectedStudentID => (int)comboBoxStudent.SelectedValue;
        public int ComboboxSubjectSelectedIndex { get => comboBoxSubject.SelectedIndex; set => comboBoxSubject.SelectedIndex = value; }
        public int SelectedSubjectID => (int)comboBoxSubject.SelectedValue;
        public bool ComboBoxSubjectEnabled { get => comboBoxSubject.Enabled; set => comboBoxSubject.Enabled = value; }
        public object GridViewData { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public bool AutoGenerateDataColumns { get => dataGridView1.AutoGenerateColumns; set => dataGridView1.AutoGenerateColumns = value; }
        public bool SelectedGradesView { get => radioButtonGrades.Checked; set => radioButtonGrades.Checked = value; }
        public bool AverageGradeButtonEnabled { get => btnAverage.Enabled; set => btnAverage.Enabled = value; }
        public string AverageGradeText { get => textBoxAverage.Text; set => textBoxAverage.Text = value; }
        public bool GradesRadioButtonEnabledState { get => radioButtonGrades.Enabled; set => radioButtonGrades.Enabled = value; }
        public bool NotesRadioButtonEnabledState { get => radioButtonNotes.Enabled; set => radioButtonNotes.Enabled = value; }

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

        public MessageResult Message(string msg, string caption = "Съобщение", MessageIcon msgIcon = MessageIcon.None, MessageButton msgBtn = MessageButton.OK)
        {
            var result = MessageBox.Show(
                    msg,
                    caption,
                    (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), msgBtn.ToString()),
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), msgIcon.ToString())
                    );

            return (MessageResult)Enum.Parse(typeof(MessageResult), result.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClick();
        }

        private void comboBoxStudent_SelectionChangeCommited(object sender, EventArgs e)
        {
            Presenter.OnStudentSelection();
        }

        private void radioButtonGrades_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.OnGradesButtonClick();
        }

        private void comboBoxSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Presenter.OnSubjectSelection();
        }

        public void ClearData()
        {
            dataGridView1.Columns.Clear();
            AverageGradeText = string.Empty;
        }

        public void DisableUnseeingData()
        {
            var checkboxCol = dataGridView1.Columns.OfType<DataGridViewCheckBoxColumn>().Single();

            foreach (var col in dataGridView1.Columns.OfType<DataGridViewTextBoxColumn>())
                col.ReadOnly = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[checkboxCol.Index].Value.ToString() == "True")
                    row.Cells[checkboxCol.Index].ReadOnly = true;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            Presenter.OnAverageGradeButtonClick();
        }

        public void FormatDataDisplay()
        {
            var checkboxCol = dataGridView1.Columns.OfType<DataGridViewCheckBoxColumn>().Single();
            checkboxCol.SortMode = DataGridViewColumnSortMode.Automatic;

            var bigCols = dataGridView1.Columns.OfType<DataGridViewTextBoxColumn>().Where(x => new string[] { "Note", "Comment" }.Contains(x.Name));
            foreach (var col in bigCols)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var gradeColumn = dataGridView1.Columns.OfType<DataGridViewTextBoxColumn>().Where(x => x.Name == "Grade").SingleOrDefault();
            if (gradeColumn != null)
                gradeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DisableUnseeingData();
            AverageGradeText = string.Empty;
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DisableUnseeingData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Presenter.OnSettingsButtonClick();
        }
    }
}
