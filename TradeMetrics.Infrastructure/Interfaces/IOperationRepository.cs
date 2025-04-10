using TradeMetrics.Domain;
using TradeMetrics.Domain.Requests;

namespace TradeMetrics.Infrastructure.Interfaces;

public interface IOperationRepository : IBaseRepository<Operation>
{
	Task<IEnumerable<Operation>> GetOperationsByFilterAsync(OperationMetricsFilterRequest filters);
}
