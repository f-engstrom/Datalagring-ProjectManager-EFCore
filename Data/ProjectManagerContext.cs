using System;
using System.Collections.Generic;
using System.Text;
using Datalagring_ProjectManager_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Datalagring_ProjectManager_EFCore.Data
{
    class ProjectManagerContext : DbContext
    {

        public DbSet<Employee> Employee { get; set; }
        public DbSet<PaymentAccount> Paymentaccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProjectManager;Trusted_Connection=True");
        }
    }
}
