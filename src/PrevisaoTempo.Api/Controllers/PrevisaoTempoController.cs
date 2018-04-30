namespace PrevisaoTempo.Api.Controllers
{
	using System.Web.Http;
	using Extension;
	using Service.BizService.Interface;

	[Route("api/PrevisaoTempo")]
	public class PrevisaoTempoController : ApiController
	{
		private readonly IPrevisaoTempoBizService _previsaoTempoBizService;

		public PrevisaoTempoController(IPrevisaoTempoBizService previsaoTempoBizService)
		{
			_previsaoTempoBizService = previsaoTempoBizService;
		}

		//Rota HTTP para request de cidades
		[Route("{cidade:alpha}")]
		public IHttpActionResult Get([FromUri] string cidade)
		{
			var retorno = _previsaoTempoBizService.ObterCidades(cidade).Cidade.ToDto();

			return Ok(retorno);
		}

		//Rota HTTP para request de previsões
		[Route("{codigoCidade:int}")]
		public IHttpActionResult Get([FromUri] int codigoCidade)
		{
			var retorno = _previsaoTempoBizService.ObterPrevisoes(codigoCidade);

			return Ok(retorno);
		}
	}
}
