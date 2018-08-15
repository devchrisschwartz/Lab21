using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class UserInfo
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Num { set; get; }
        public string Pass { set; get; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Num = "";
            Pass = "";
        }

        public UserInfo(string fn, string ln, string e, string t, string pass)
        {
            FirstName = fn;
            LastName = ln;
            Email = e;
            Num = t;
            Pass = pass;
        }
    }
}