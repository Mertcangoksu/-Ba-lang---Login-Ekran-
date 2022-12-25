using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Login.Models
{
    public class User  // user diye class oluşturduk
    {   

        public User(string _userName,string _password) // const oluşturup içerisine parametre koyduk
        {
            userName = _userName;  // içini doldurduk
            password = _password;  // "  " 
        }
        public string userName { get; set; }   // proplarımız
        public string password { get; set; }
    }
}
