using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDbContext : DbContext
{
	public DbSet<Expense> Expenses { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString = "Server=localhost;Database=cashflowdb;Uid=alexandre;Pwd=Th2qdt6j#";

		var version = new Version(8, 0, 45);
		var serverVersion = new MySqlServerVersion(version);
		optionsBuilder.UseMySql(connectionString, serverVersion);
	}
}
