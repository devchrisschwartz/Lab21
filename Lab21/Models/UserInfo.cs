using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class UserInfo
    {
        [Required]
        [RegularExpression("[a-zA-Z]{2,30}")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("[a-zA-Z]{2,30}")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"\w{2,30}@[a-zA-Z]{2,15}\.[a-zA-Z]{3}")]
        public string Email { set; get; }

        [RegularExpression(@"\d{10}|\d{3}-\d{3}-\d{4}")]
        public string Num { set; get; }

        [Required]
        [RegularExpression("[a-zA-Z]{2,30}")]
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