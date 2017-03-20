using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2ListAndMoreList.Models
{
   
    public partial class User
    {
        private string _name;
        private string _password;
        private string _user;

        public User()
        {
            Name = _name;
            Password = _password;
        }

       
        //property:
        public string Name { get;  set; }
        public string Password { get;  set; }
    
       
        public override string ToString()
        {
            //return string format.
            //return string with both user name and password as lowercase.
            //http://stackoverflow.com/questions/491334/why-does-boolean-tostring-output-true-and-not-true
            return ("Name: " + Name + "      Password: " + Password).ToLower();
        }
 
    }
}
