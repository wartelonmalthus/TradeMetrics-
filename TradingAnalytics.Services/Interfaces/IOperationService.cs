using TradeMetrics.Domain.Requests;
using TradeMetrics.Domain.Responses;

namespace TradingAnalytics.Services.Interfaces;

public interface IOperationService
{
	Task AddOperation(OperationRequest request);
	Task AddOperationList(List<OperationRequest> requests);
	Task<IEnumerable<OperationRequest>> GetOperationList();
	Task<OperationMetricsResponse> GetMetrics();
}
