using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11._2CoffeeRegistration2.Models
{
    public class NUser
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public int age { get; set; }
        public string phonenumber { get; set; }

        public static List<NUser> AllNUser = new List<NUser>();
    }
}
