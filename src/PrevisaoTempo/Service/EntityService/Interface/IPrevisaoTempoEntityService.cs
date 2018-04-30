namespace PrevisaoTempo.Service.EntityService.Interface
{
	using Model;

	public interface IPrevisaoTempoEntityService
	{
		Cidades ObterCidades(string cidade);

		PrevisaoTo.Cidade ObterPrevisoes(int codigoPrevisao);
	}
}
