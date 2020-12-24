using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class SessionList : List<SessionInfo>
    {
        public static SessionList GetDefaultSessionList()
        {
            SessionList myList = new SessionList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-4ID3ANV\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSessionList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                SessionInfo newSession = new SessionInfo();
                newSession.SessionID = (int)dr["SessionID"];
                newSession.SessionMark = dr["SessionMark"].ToString();

                myList.Add(newSession);
            }
            return myList;
        }
    }
}