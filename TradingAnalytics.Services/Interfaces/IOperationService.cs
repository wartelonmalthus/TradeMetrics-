using TradeMetrics.Domain.Requests;

namespace TradingAnalytics.Services.Interfaces;

public interface IOperationService
{
	Task AddOperation(OperationRequest request);
	Task AddOperationList(List<OperationRequest> requests);
	Task<IEnumerable<OperationRequest>> GetOperationList();
}
