using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Core.DTO
{
    public class LoginDTO
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public LoginDTO(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
