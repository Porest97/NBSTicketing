using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NBSTicketing.Models.DataModels;

namespace NBSTicketing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NBSTicketing.Models.DataModels.Company> Company { get; set; }
        public DbSet<NBSTicketing.Models.DataModels.CompanyType> CompanyType { get; set; }
        public DbSet<NBSTicketing.Models.DataModels.Person> Person { get; set; }
        public DbSet<NBSTicketing.Models.DataModels.PersonType> PersonType { get; set; }
        public DbSet<NBSTicketing.Models.DataModels.Site> Site { get; set; }
        public DbSet<NBSTicketing.Models.DataModels.SiteType> SiteType { get; set; }
    }
}
