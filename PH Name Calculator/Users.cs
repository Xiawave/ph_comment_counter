using System;

namespace PH_Name_Calculator
{
    class Users
    {
        private string _username;
        private int _commentcount;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int commentcount
        {
            get { return _commentcount; }
            set { _commentcount = value; }
        }

        public Users(string _username)
        {
            username = _username;
            commentcount = 1;
        }
    }
}
