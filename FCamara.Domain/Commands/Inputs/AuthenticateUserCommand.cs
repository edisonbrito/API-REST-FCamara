using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Domain.Commands.Inputs
{
    public class AuthenticateUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
