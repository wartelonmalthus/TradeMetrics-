using TradeMetrics.Domain.Requests;
using TradeMetrics.Infrastructure.Interfaces;
using TradingAnalytics.Services.Interfaces;

namespace TradingAnalytics.Services.Services;

public class OperationService(IOperationRepository operationRepository) : IOperationService
{
	private readonly IOperationRepository _operationRepository = operationRepository;

	public Task AddOperation(OperationMetricsFilterRequest filter)
	{
		throw new NotImplementedException();
	}
}
