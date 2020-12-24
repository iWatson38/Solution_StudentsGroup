using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class StudentList : List<StudentInfo>
    {
        public static StudentList GetDefaultStudentList()
        {
            StudentList myList = new StudentList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetStudentList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                StudentInfo newStudent = new StudentInfo();
                newStudent.StudentID = (int)dr["StudentID"];
                newStudent.StudentFirstName = dr["StudentFirstName"].ToString();
                newStudent.StudentLastName = dr["StudentLastName"].ToString();
                newStudent.StudentMiddleName = dr["StudentMiddleName"].ToString();
                newStudent.StudentDataBirth = (DateTime)dr["StudentDataBirth"];
                newStudent.StudentGroup = dr["StudentGroup"].ToString();
                newStudent.ModeStudyID = (int)dr["ModeStudyID"];
                newStudent.ModeStudyName = dr["ModeStudyName"].ToString();
                newStudent.SessionID = (int)dr["SessionID"];
                newStudent.SessionMark = dr["SessionMark"].ToString();

                myList.Add(newStudent);
            }

            return myList;
        }
    }
}
