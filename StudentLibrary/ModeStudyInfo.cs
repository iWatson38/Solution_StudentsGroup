using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentLibrary
{
    public class ModeStudyInfo
    {
        private int _modeStudyID = 0;
        private string _modeStudyName = "";

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
    }
}