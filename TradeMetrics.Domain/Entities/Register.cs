namespace TradeMetrics.Domain;

public abstract class Register
{
    public int Id { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public DateTime DataDeAlteracao { get; set; }

    public Register()
    { 
        this.DataDeCriacao = DateTime.Now;  
    }
}