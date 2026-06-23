using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MS.Financial.Web.Models.Entities;

namespace MS.Financial.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<DebtCase> DebtCases { get; set; }
        public DbSet<CreditReport> CreditReports { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void onModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Client>()
                .HasIndex(c => c.IdentityNumber)
                .IsUnique();
        }
    }
}