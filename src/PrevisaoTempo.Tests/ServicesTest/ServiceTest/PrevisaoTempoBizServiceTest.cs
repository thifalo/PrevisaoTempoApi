namespace PrevisaoTempo.Tests.ServicesTest.ServiceTest
{
	using Autofac;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
	using Service.BizService.Interface;

	[TestClass]
	public class RetornoServicos : BaseTests
	{
		private IPrevisaoTempoBizService _previsaoTempoBizService;

		[TestInitialize]
		public override void Setup()
		{
			base.Setup();

			_previsaoTempoBizService = Container.Resolve<IPrevisaoTempoBizService>();
		}

		[TestMethod]
		public void ValidarChamadaBizService()
		{
			string parametro = "Curitiba";

			Cidades cidades = new Cidades();

			var retorno = _previsaoTempoBizService.ObterCidades(parametro);

			var tipo = retorno.GetType();

			Assert.AreEqual(cidades.GetType().Name, tipo.Name, "O objeto de retorno não é do tipo esperado!");
		}
	}
}
