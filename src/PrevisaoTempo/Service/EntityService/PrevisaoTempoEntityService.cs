namespace PrevisaoTempo.Service.EntityService
{
	using System.IO;
	using System.Net;
	using System.Xml.Serialization;
	using Interface;
	using Model;

	public class PrevisaoTempoEntityService : IPrevisaoTempoEntityService
	{
		// Request para serviço externo (obter cidades)
		public Cidades ObterCidades(string cidade)
		{
			WebRequest getCidade = WebRequest.Create("http://servicos.cptec.inpe.br/XML/listaCidades?city=" + cidade);
			XmlSerializer serializer = new XmlSerializer(typeof(Cidades));
			using (var responseCidade = (HttpWebResponse)getCidade.GetResponse())
			{
				using (var dataStream = responseCidade.GetResponseStream())
				{
					var cidadeSelecionada = (Cidades)serializer.Deserialize(dataStream);
					responseCidade.Close();
					dataStream.Close();

					return cidadeSelecionada;
				}
			}
		}

		// Request para serviço externo (obter previsões)
		public PrevisaoTo.Cidade ObterPrevisoes(int codigoPrevisao)
		{
			WebRequest getPrevisao = WebRequest.Create("http://servicos.cptec.inpe.br/XML/cidade/7dias/" + codigoPrevisao + "/previsao.xml");
			HttpWebResponse responsePrevisao = (HttpWebResponse)getPrevisao.GetResponse();
			Stream dataStream1 = responsePrevisao.GetResponseStream();
			XmlSerializer serializer1 = new XmlSerializer(typeof(PrevisaoTo.Cidade));
			var previsoes = (PrevisaoTo.Cidade)serializer1.Deserialize(dataStream1);
			responsePrevisao.Close();
			dataStream1.Close();

			return previsoes;
		}
	}
}
