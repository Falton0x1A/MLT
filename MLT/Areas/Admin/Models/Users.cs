using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLT.Areas.Admin.Models
{
    public class Users : IdentityUser
    {
       public string Username { get; set; }
       public string EmailAddress { get; set; }
        public class ProjectsDbContext : IdentityDbContext<IdentityUser>
        {
            public ProjectsDbContext(DbContextOptions<ProjectsDbContext> options)
                : base(options)
            {
            }
        }
    }
}
