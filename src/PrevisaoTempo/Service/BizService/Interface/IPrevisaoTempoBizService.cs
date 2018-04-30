namespace PrevisaoTempo.Service.BizService.Interface
{
	using Model;

	public interface IPrevisaoTempoBizService
	{
		Cidades ObterCidades(string cidade);

		PrevisaoTo.Cidade ObterPrevisoes(int codigoPrevisao);
	}
}
