using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Entity
{
    public class Card
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [AllowNull]
        public User User { get; set; }
        [AllowNull]
        public string CardNumbers { get; set; }
        [AllowNull]
        public string CardPassword { get; set; }
        public double AccessibleMoney { get; set; }
    }
}
