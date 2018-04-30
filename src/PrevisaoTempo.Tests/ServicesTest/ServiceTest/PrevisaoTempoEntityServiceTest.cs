namespace PrevisaoTempo.Tests.ServicesTest.ServiceTest
{
	using Autofac;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Service.EntityService.Interface;

	[TestClass]
	public class PrevisaoTempoEntityServiceTest : BaseTests
	{

		private IPrevisaoTempoEntityService _previsaoTempoEntityService;

		[TestInitialize]
		public override void Setup()
		{
			base.Setup();

			_previsaoTempoEntityService = Container.Resolve<IPrevisaoTempoEntityService>();
		}

		[TestMethod]
		public void ValidarRetornoEntityService()
		{
			int codigoCidade = 227;

			var retorno = _previsaoTempoEntityService.ObterPrevisoes(codigoCidade);

			Assert.AreEqual("Curitiba", retorno.Nome, "Request não obteve sucesso!");
		}
	}
}
