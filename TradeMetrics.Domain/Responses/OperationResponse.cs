using TradeMetrics.Domain.Enums;

namespace TradeMetrics.Domain.Responses;

public class OperationResponse
{
	public int Id { get; set; }
	public CoinPair ParDeMoedas { get; set; }
	public TimeSpan Horario { get; set; }
	public Result Resultado { get; set; }
	public Gale Gale { get; set; }
	public SignalList NomeDaLista { get; set; }
	public DateTime DataDeCriacao { get; set; }
	public DateTime DataDeAlteracao { get; set; }
}
