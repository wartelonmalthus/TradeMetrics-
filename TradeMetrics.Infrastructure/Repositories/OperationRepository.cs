using Microsoft.EntityFrameworkCore;
using TradeMetrics.Domain;
using TradeMetrics.Domain.Requests;
using TradeMetrics.Infrastructure.Context;
using TradeMetrics.Infrastructure.Interfaces;

namespace TradeMetrics.Infrastructure.Repositories;

public class OperationRepository(TradeContext context) : BaseRepository<Operation>(context), IOperationRepository
{
	public Task<IEnumerable<Operation>> GetOperationsByFilterAsync(OperationMetricsFilterRequest filters)
	{
		var query = _context.Operacao.AsQueryable();

		if (filters.ParDeMoedas is not null)
		{
			query = query.Where(op => op.ParDeMoedas == filters.ParDeMoedas);
		}

		if (filters.Horario.HasValue)
		{
			query = query.Where(op => op.Horario == filters.Horario.Value);
		}

		if (filters.DataDaOperacao.HasValue)
		{
			query = query.Where(op => op.DataDaOperacao.Date == filters.DataDaOperacao.Value.Date);
		}

		return await query.ToListAsync();
	}
}
