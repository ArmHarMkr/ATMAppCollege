using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Entity
{
    public class User
    {
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public char Gender { get; set; }
    }
}
