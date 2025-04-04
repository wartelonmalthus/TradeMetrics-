using TradeMetrics.Domain.Enums;

namespace TradeMetrics.Domain.Requests;

public class OperationMetricsFilterRequest
{
	public CoinPair ParDeMoedas { get; set; }
	public TimeSpan Horario { get; set; }

}