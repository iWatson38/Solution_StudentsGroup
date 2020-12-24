using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;

namespace StudentWindows
{
    public partial class StudentForm : Form
    {
        StudentList _studentList = new StudentList();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshStudentList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentEditForm newForm = new StudentEditForm();

            newForm.ShowDialog();
            RefreshStudentList();
        }

        void RefreshStudentList()
        {
            _studentList = StudentList.GetDefaultStudentList();
            studentListBindingSource.DataSource = null;
            studentListBindingSource.DataSource = _studentList;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int studID = (int)studentListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (StudentInfo student in _studentList)
            {
                if (student.StudentID == studID)
                {
                    student.DeleteStudent();
                }
            }
            RefreshStudentList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int studID = (int)studentListDataGridView.SelectedRows[0].Cells[0].Value;

            StudentEditForm newForm = new StudentEditForm();

            foreach (StudentInfo student in _studentList)
            {
                student.GetStudent(studID);
                newForm._newStudent = student;
            }
            newForm.ShowDialog();
            RefreshStudentList();
        }
    }
}
