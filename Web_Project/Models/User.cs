using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string BirthdayDate { get; set; }
        public string CreateDate { get; set; }
        public string School { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string Interest { get; set; }
        public string Summary { get; set; }
        public string Website { get; set; }
        public string Github { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }

    }
}
