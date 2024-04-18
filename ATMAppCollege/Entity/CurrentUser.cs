using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Entity
{
    public static class CurrentUser
    {
        public static User User { get; set; } = new();
    }
}
