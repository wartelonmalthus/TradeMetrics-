using TradeMetrics.Domain;
using TradeMetrics.Domain.Requests;
using TradeMetrics.Domain.Responses;

namespace TradingAnalytics.Services.Mapper;

public static class OperationMapper
{
	public static Operation ToEntity(this OperationRequest request) => new() 
	{
		Resultado = request.Resultado,
		Gale = request.Gale,
		Horario = request.Horario,
		NomeDaLista = request.NomeDaLista,
		ParDeMoedas = request.ParDeMoedas,
		DataDeCriacao = request.DataDaOperacao
	};

	public static OperationResponse ToResponse(this Operation entity) => new()
	{
		Resultado = entity.Resultado,	
		Gale = entity.Gale,
		Horario = entity.Horario,
		NomeDaLista = entity.NomeDaLista,
		Id = entity.Id,
		ParDeMoedas = entity.ParDeMoedas,
		DataDeCriacao = entity.DataDeCriacao,
		DataDeAlteracao = entity.DataDeAlteracao

	};

	public static List<OperationResponse> ToListResponse(this List<Operation> entities)
	{
		return (List<OperationResponse>)entities.Select(entity => entity.ToResponse());
	}

	public static List<Operation> ToListEntity(this List<OperationRequest> requests)
	{
		return (List<Operation>)requests.Select(entity => entity.ToEntity());
	}
}
