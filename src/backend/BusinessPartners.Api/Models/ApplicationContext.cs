using System;
using BusinessPartners.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessPartners.Api.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<BusinessPartner> BusinessPartners { get; set; }
    }
}

