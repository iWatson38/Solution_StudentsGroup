using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class StudentInfo
    {
        private string _studentFirstName = "";
        private string _studentLastName = "";
        private string _studentMiddleName = "";
        private DateTime _studentDataBirth = DateTime.Today;
        private string _studentGroup = "";
        private int _studentID = 0;
        private int _sessionID = 0;
        private string _sessionMark = "";
        private int _modeStudyID = 0;
        private string _modeStudyName = "";

        public int StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        public string StudentFirstName
        {
            get
            {
                return _studentFirstName;
            }
            set
            {
                _studentFirstName = value;
            }
        }

        public string StudentLastName
        {
            get
            {
                return _studentLastName;
            }
            set
            {
                _studentLastName = value;
            }
        }

        public string StudentMiddleName
        {
            get
            {
                return _studentMiddleName;
            }
            set
            {
                _studentMiddleName = value;
            }
        }

        public DateTime StudentDataBirth
        {
            get
            {
                return _studentDataBirth;
            }
            set
            {
                _studentDataBirth = value;
            }
        }

        public string StudentGroup
        {
            get
            {
                return _studentGroup;
            }
            set
            {
                _studentGroup = value;
            }
        }

        public int SessionID
        {
            get
            {
                return _sessionID;
            }
            set
            {
                _sessionID = value;
            }
        }

        public string SessionMark
        {
            get
            {
                return _sessionMark;
            }
            set
            {
                _sessionMark = value;
            }
        }

        public int ModeStudyID
        {
            get
            {
                return _modeStudyID;
            }
            set
            {
                _modeStudyID = value;
            }
        }

        public string ModeStudyName
        {
            get
            {
                return _modeStudyName;
            }
            set
            {
                _modeStudyName = value;
            }
        }

        public void InsertNewStudent()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertStudent";
            
            cm.Parameters.Add(new SqlParameter("@StudentFirstName", _studentFirstName));
            cm.Parameters.Add(new SqlParameter("@StudentLastName", _studentLastName));
            cm.Parameters.Add(new SqlParameter("@StudentMiddleName", _studentMiddleName));
            cm.Parameters.Add(new SqlParameter("@StudentDataBirth", _studentDataBirth));
            cm.Parameters.Add(new SqlParameter("@StudentGroup", _studentGroup));
            cm.Parameters.Add(new SqlParameter("@ModeStudyID", _modeStudyID));
            cm.Parameters.Add(new SqlParameter("@SessionID", _sessionID));

            cm.ExecuteNonQuery();
        }

        public void DeleteStudent()
        {
            StudentList myList = new StudentList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteStudent";

            cm.Parameters.Add(new SqlParameter("@StudentID", _studentID));
            
            cm.ExecuteNonQuery();
        }

        public void UpdateStudent()
        {
            StudentList myList = new StudentList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateStudent";

            cm.Parameters.Add(new SqlParameter("@StudentID", _studentID));
            cm.Parameters.Add(new SqlParameter("@StudentFirstName", _studentFirstName));
            cm.Parameters.Add(new SqlParameter("@StudentLastName", _studentLastName));
            cm.Parameters.Add(new SqlParameter("@StudentMiddleName", _studentMiddleName));
            cm.Parameters.Add(new SqlParameter("@StudentDataBirth", _studentDataBirth));
            cm.Parameters.Add(new SqlParameter("@StudentGroup", _studentGroup));
            cm.Parameters.Add(new SqlParameter("@ModeStudyID", _modeStudyID));
            cm.Parameters.Add(new SqlParameter("@SessionID", _sessionID));

            cm.ExecuteNonQuery();
        }

        public void GetStudent(int studentID)
        {
            StudentList myList = new StudentList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetStudent";

            cm.Parameters.Add(new SqlParameter("@StudentID", studentID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _studentID = (int)dr["StudentID"];
                _studentFirstName = dr["studentFirstName"].ToString();
                _studentLastName = dr["StudentLastName"].ToString();
                _studentMiddleName = dr["StudentMiddleName"].ToString();
                _studentDataBirth = (DateTime)dr["StudentDataBirth"];
                _modeStudyID = (int)dr["ModeStudyID"];
                _modeStudyName = dr["ModeStudyName"].ToString();
                _sessionID = (int)dr["SessionID"];
                _sessionMark = dr["SessionMark"].ToString();
            }
        }
    }
}