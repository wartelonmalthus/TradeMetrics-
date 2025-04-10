using Microsoft.EntityFrameworkCore;
using TradeMetrics.Domain;
using TradeMetrics.Domain.Requests;
using TradeMetrics.Infrastructure.Context;
using TradeMetrics.Infrastructure.Interfaces;

namespace TradeMetrics.Infrastructure.Repositories;

public class OperationRepository(TradeContext context) : BaseRepository<Operation>(context), IOperationRepository
{
	public async Task<IEnumerable<Operation>> GetOperationsByFilterAsync(OperationMetricsFilterRequest filters)
	{
		var query = _context.Operacao.AsQueryable();

		if (filters.ParDeMoedas.ToString() is not null)
		{
			query = query.Where(op => op.ParDeMoedas.ToString() == filters.ParDeMoedas.ToString());
		}

		if (filters.Horario.TotalHours > 0)
		{
			query = query.Where(op => op.Horario == filters.Horario);
		}

		if (filters.DataDaOperacao != null)
		{
			query = query.Where(op => op.DataDeCriacao == filters.DataDaOperacao);
		}

		return await query.ToListAsync();
	}
}
