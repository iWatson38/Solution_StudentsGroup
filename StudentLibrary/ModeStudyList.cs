using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class ModeStudyList : List<ModeStudyInfo>
    {
        public static ModeStudyList GetDefaultModeStudyList()
        {
            ModeStudyList myList = new ModeStudyList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetModeStudyList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ModeStudyInfo newModeStudy = new ModeStudyInfo();
                newModeStudy.ModeStudyID = (int)dr["ModeStudyID"];
                newModeStudy.ModeStudyName = dr["ModeStudyName"].ToString();

                myList.Add(newModeStudy);
            }
            return myList;
        }
    }
}