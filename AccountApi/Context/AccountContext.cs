using Core;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Context;

public class AccountContext(DbContextOptions<AccountContext> options) : DbContext(options)
{
    public DbSet<Account> Accounts { get; init; } = null!;
    public DbSet<Bank> Banks { get; init; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;
        var connectionString = Environment.GetEnvironmentVariable("DefaultConnection") ??
                               "Server=localhost;Database=AccountCentralBank;User id=postgres;Password=central_bank";
        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasIndex(a => a.PixKey).IsUnique();
    }
}