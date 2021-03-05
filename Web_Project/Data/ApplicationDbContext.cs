using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Web_Project.Models;

namespace Web_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Question> Question { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
