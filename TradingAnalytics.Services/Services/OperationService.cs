using TradeMetrics.Domain.Requests;
using TradeMetrics.Infrastructure.Interfaces;
using TradingAnalytics.Services.Interfaces;
using TradingAnalytics.Services.Mapper;

namespace TradingAnalytics.Services.Services;

public class OperationService(IOperationRepository operationRepository) : IOperationService
{
	private readonly IOperationRepository _operationRepository = operationRepository;

	public async Task AddOperation(OperationRequest request)
	{
		await _operationRepository.AddAsync(request.ToEntity());
	}

	public async Task AddOperationList(List<OperationRequest> requests)
	{
		await _operationRepository.AddListAsync(requests.ToListEntity());
	}

	public async Task<IEnumerable<OperationRequest>> GetOperationList()
	{
		//var (items, total) = await _operationRepository.GetAllAsync(1, 10);
		//return items.to
			throw new NotImplementedException();
	}
}
