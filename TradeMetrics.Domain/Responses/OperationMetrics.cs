using TradeMetrics.Domain.Enums;

namespace TradeMetrics.Domain.Responses;

public class OperationMetrics
{
	public CoinPair ParDeMoedas { get; set; }
	public int TotalOperacoes { get; set; }
	public int TotalWin {  get; set; }
	public int TotalLoss { get; set; }
	public decimal TaxaDeVitoria { get; set; }
	public decimal TaxaSemGale { get; set; }
	public decimal TaxaGale1 { get; set; }

}
