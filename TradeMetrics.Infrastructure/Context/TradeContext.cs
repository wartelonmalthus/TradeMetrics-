using Microsoft.EntityFrameworkCore;
using TradeMetrics.Domain;

namespace TradeMetrics.Infrastructure.Context;

public class TradeContext : DbContext
{
	public TradeContext(DbContextOptions<TradeContext> options)
	: base(options)
	{
	}

	public DbSet<Operation> Operacao { get; set; }

}