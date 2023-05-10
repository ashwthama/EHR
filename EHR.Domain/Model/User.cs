using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Domain.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public string ProfileImg { get; set; }

    }
}
