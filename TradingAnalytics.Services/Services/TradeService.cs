using TradingAnalytics.Services.Interfaces;

namespace TradingAnalytics.Services.Services;

public class TradeService(ITradeService tradeService) : ITradeService
{
	private readonly ITradeService _tradeService  = tradeService;
}
