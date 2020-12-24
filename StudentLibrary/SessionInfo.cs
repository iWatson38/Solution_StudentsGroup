using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class SessionInfo
    {
        private int _sessionID = 0;
        private string _sessionMark = "";

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
    }
}