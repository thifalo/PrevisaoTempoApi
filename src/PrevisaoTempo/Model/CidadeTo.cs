namespace PrevisaoTempo.Model
{
	using System.Collections.Generic;
	using System.Xml.Serialization;

	[XmlRoot(ElementName = "cidade")]
	public class CidadeTo
	{
		[XmlElement(ElementName = "nome")]
		public string Nome { get; set; }
		[XmlElement(ElementName = "uf")]
		public string Uf { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "cidades")]
	public class Cidades
	{
		[XmlElement(ElementName = "cidade")]
		public List<CidadeTo> Cidade { get; set; }
	}
}
