using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using System.Windows.Forms;

namespace StudentWindows
{
    public partial class StudentEditForm : Form
    {
        public StudentInfo _newStudent = new StudentInfo();

        public StudentEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_newStudent.StudentID > 0)
            {
                _newStudent.UpdateStudent();
            }
            else
            {
                _newStudent.InsertNewStudent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentEditForm_Load(object sender, EventArgs e)
        {
            studentInfoBindingSource.DataSource = _newStudent;

            SessionList _sessionList = SessionList.GetDefaultSessionList();
            sessionlistbindingSource.DataSource = _sessionList;
            _newStudent.SessionID = _sessionList[0].SessionID;
            ModeStudyList _modeStudyList = ModeStudyList.GetDefaultModeStudyList();

            modeStudyListBindingSource.DataSource = _modeStudyList;
            _newStudent.ModeStudyID = _modeStudyList[0].ModeStudyID;

        }

        private void modeStudyIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
