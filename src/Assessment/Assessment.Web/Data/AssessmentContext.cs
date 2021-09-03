using Assessment.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Data
{
        public class AssessmentContext : DbContext
        {
            public AssessmentContext(DbContextOptions<AssessmentContext> options)
                : base(options)
            {
            }

            public DbSet<CalculationHistory> CalculationHistories { get; set; }
            

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<CalculationHistory>().ToTable("CalculationHistories");
            }
    }
}
