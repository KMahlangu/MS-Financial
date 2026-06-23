public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbConetextOptions<ApplicationsDbContext> options)
        : base(options)
    {

    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<DebtCase> DebtCases { get; set; }
    public DbSet<CreditReport> CreditReports { get; set; }
    public DbSet<Document> Documents { get; set; }
}