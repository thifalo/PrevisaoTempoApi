namespace PrevisaoTempo.Model
{
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Xml.Serialization;
	using Exstension;

	[XmlRoot(ElementName = "previsao")]
	public class PrevisaoTo
	{
		[XmlRoot(ElementName = "previsao")]
		public class Previsao
		{
			[XmlElement(ElementName = "dia")]
			public string Dia { get; set; }

			[XmlElement(ElementName = "tempo")]
			public Clima Tempo { get; set; }

			[XmlElement(ElementName = "maxima")]
			public string Maxima { get; set; }

			[XmlElement(ElementName = "minima")]
			public string Minima { get; set; }

			[XmlElement(ElementName = "iuv")]
			public string Iuv { get; set; }

			public string TempoDescricao
			{
				get { return Tempo.ObterDescricao(); }
			}
		}

		[XmlRoot(ElementName = "cidade")]
		public class Cidade
		{
			[XmlElement(ElementName = "nome")]
			public string Nome { get; set; }

			[XmlElement(ElementName = "uf")]
			public string Uf { get; set; }

			[XmlElement(ElementName = "atualizacao")]
			public string Atualizacao { get; set; }

			[XmlElement(ElementName = "previsao")]
			public List<Previsao> Previsao { get; set; }
		}


		public enum Clima
		{
			[Description("Encoberto com Chuvas Isoladas")]
			[XmlEnum("ec")]
			EncobertoChuvasIsoladas = 0,

			[Description("Chuvas Isoladas")]
			[XmlEnum("ci")]
			Chuvaisolada = 1,
			[Description("Chuva")] [XmlEnum("c")] Chuva = 2,

			[Description("Instável")]
			[XmlEnum("in")]
			Instavel = 3,

			[Description("Possibilidade de Pancadas de Chuva")]
			[XmlEnum("pp")]
			PossibilidadePancadaChuva = 4,

			[Description("Chuva pela Manhã")]
			[XmlEnum("cm")]
			ChuvaManha = 5,

			[Description("Chuva pela Noite")]
			[XmlEnum("cn")]
			ChuvaNoite = 6,

			[Description("Pancadas de Chuva a Tarde")]
			[XmlEnum("pt")]
			PancadaChuvaTarde = 7,

			[Description("Pancadas de Chuva pela Manhã")]
			[XmlEnum("pm")]
			PancadaChuvaManha = 8,

			[Description("Nublado e Pancadas de Chuva")]
			[XmlEnum("np")]
			NubladoPancadaChuva = 9,

			[Description("Pancadas de Chuva")]
			[XmlEnum("pc")]
			PancadaCHuva = 10,

			[Description("Parcialmente Nublado")]
			[XmlEnum("pn")]
			ParcialmenteNublado = 11,

			[Description("Chuvisco")]
			[XmlEnum("cv")]
			Chuvisco = 12,

			[Description("Chuvoso")]
			[XmlEnum("ch")]
			Chuvoso = 38,

			[Description("Tempestade")]
			[XmlEnum("t")]
			Tempestade = 13,

			[Description("Predomínio de Sol")]
			[XmlEnum("ps")]
			PredominioSol = 14,

			[Description("Encoberto")]
			[XmlEnum("e")]
			Encobero = 15,

			[Description("Nublado")]
			[XmlEnum("n")]
			Nublado = 16,

			[Description("Céu Claro")]
			[XmlEnum("cl")]
			CeuClaro = 17,

			[Description("Nevoeiro")]
			[XmlEnum("nv")]
			Nevoeiro = 18,

			[Description("Geada")]
			[XmlEnum("g")]
			Geada = 19,

			[Description("Neve")]
			[XmlEnum("ne")]
			Neve = 20,

			[Description("Pancadas de Chuva a Noite")]
			[XmlEnum("pnt")]
			PancadaChuvaNoite = 21,

			[Description("Possibilidade de Chuva")]
			[XmlEnum("psc")]
			PossibilidadeChuva = 22,

			[Description("Possibilidade de Chuva pela Manhã")]
			[XmlEnum("pcm")]
			PossibilidadeChuvaManha = 23,

			[Description("Possibilidade de Chuva a Tarde")]
			[XmlEnum("pct")]
			PossibilidadeChuvaTarde = 24,

			[Description("Possibilidade de Chuva a Noite")]
			[XmlEnum("pcn")]
			PossibilidadeChuvaNoite = 25,

			[Description("Nublado com Pancadas a Tarde")]
			[XmlEnum("npt")]
			NubladoPancadaTarde = 26,

			[Description("Nublado com Pancadas a Noite")]
			[XmlEnum("npn")]
			NubladoPancadaNoite = 27,

			[Description("Nublado com Possibilidade de Chuva a Noite")]
			[XmlEnum("ncn")]
			NubladoPossibilidadeChuvaNoite = 28,

			[Description("Nublado com Possibilidade de Chuva a Tarde")]
			[XmlEnum("nct")]
			NubladoPossibilidadeChuvaTarde = 29,

			[Description("Nublado com Possibilidade de Chuva pela Manhã")]
			[XmlEnum("ncm")]
			NubladoPossibilidadeChuvaManha = 30,

			[Description("Nublado com Pancadas pela Manhã")]
			[XmlEnum("npm")]
			NubladoPancadaManha = 31,

			[Description("Nublado com Possibilidade de Chuva")]
			[XmlEnum("npp")]
			NubladoPossibilidadeChuva = 32,

			[Description("Variação de Nebulosidade")]
			[XmlEnum("vn")]
			VariacaoNebulosidade = 33,

			[Description("Chuva a Tarde")]
			[XmlEnum("ct")]
			ChuvaTarde = 34,

			[Description("Possibilidade de Pancadas de Chuva a Noite")]
			[XmlEnum("ppn")]
			PossibilidadePancadaChuvaNoite = 34,

			[Description("Possibilidade de Pancadas de Chuva a Tarde")]
			[XmlEnum("ppt")]
			PossibilidadePancadaChuvaTarde = 35,

			[Description("Possibilidade de Pancadas de Chuva pela Manhã")]
			[XmlEnum("ppm")]
			PossibilidadePancadaChuvaManha = 36,

			[Description("Não Definido")]
			[XmlEnum("it")] NaoDefinido = 37
		}
	}
}
