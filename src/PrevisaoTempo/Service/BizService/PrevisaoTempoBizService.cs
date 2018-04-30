namespace PrevisaoTempo.Service.BizService
{
	using EntityService.Interface;
	using Interface;
	using Model;

	public class PrevisaoTempoBizService : IPrevisaoTempoBizService
	{
		private readonly IPrevisaoTempoEntityService _previsaoTempoEntityService;

		// Chamada para entity service retornar dados do serviço
		public PrevisaoTempoBizService(IPrevisaoTempoEntityService previsaoTempoEntityService)
		{
			_previsaoTempoEntityService = previsaoTempoEntityService;
		}

		public Cidades ObterCidades(string cidade)
		{
			var resultado = _previsaoTempoEntityService.ObterCidades(cidade);

			return resultado;
		}

		public PrevisaoTo.Cidade ObterPrevisoes(int codigoPrevisao)
		{
			var resultado = _previsaoTempoEntityService.ObterPrevisoes(codigoPrevisao);
			return resultado;
		}
	}
}
