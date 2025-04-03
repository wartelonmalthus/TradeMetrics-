using TradeMetrics.Domain.Enums;

namespace TradeMetrics.Domain;

public class Operation : Register
{
   public CoinPair ParDeMoedas { get; set; }
   public TimeSpan Horario { get; set; }	
   public Result Resultado { get; set; }  
   public Gale Gale { get; set; }
   public SignalList NomeDaLista { get; set; }
   
}