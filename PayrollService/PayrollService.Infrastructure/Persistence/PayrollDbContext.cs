using Microsoft.EntityFrameworkCore;
using PayrollService.Domain.Entities;

namespace PayrollService.Infrastructure.Persistence;

public class PayrollDbContext : DbContext
{
    public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }

    public DbSet<Payroll> Payrolls => Set<Payroll>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Payroll>().ToTable("Payrolls");
    }
}
