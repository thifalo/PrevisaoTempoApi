namespace PrevisaoTempo.Api.Extension
{
	using System.Collections.Generic;
	using System.Linq;
	using Dto;
	using Model;

	// Classe de extensão para converter objetos do tipo TO para DTO
	public static class PrevisaoTempoExtension
	{
		// Conversão do objeto Cidade TO para DTO
		public static List<CidadeDto> ToDto(this List<CidadeTo> cidadeTos)
		{
			return cidadeTos.Select(a => new CidadeDto
			{
				Id = a.Id,
				Nome = a.Nome,
				Uf = a.Uf
			}).ToList();
		}

		// Conversão de objeto PrevisaoTo para DTO
		public static PrevisaoTo.Cidade ToDto(this PrevisaoTo.Cidade previsaoTos)
		{
			return new PrevisaoTo.Cidade
			{
				Nome = previsaoTos.Nome,
				Uf = previsaoTos.Uf,
				Atualizacao = previsaoTos.Atualizacao,
				Previsao = previsaoTos.Previsao
			};
		}
	}
}
