using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class ViewModel
    {
        public List<Project> Project { get; set; }
        public List<Category> Category { get; set; }
        public List<User> User { get; set; }
        public List<Question> Question { get; set; }

    }
}
