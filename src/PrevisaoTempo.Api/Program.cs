namespace PrevisaoTempo.Api
{
	using System;
	using System.Net.Http.Formatting;
	using System.Web.Http;
	using System.Web.Http.SelfHost;
	using Autofac;
	using Autofac.Integration.WebApi;
	using Controllers;
	using Service.BizService;
	using Service.EntityService;
	using System.Web.Http.Cors;

	class Program
	{
		static void Main(string[] args)
		{
			// Inicio do registro de injeção de depenências com AUTOFAC
			var builder = new ContainerBuilder();
			builder.RegisterType<PrevisaoTempoController>().InstancePerRequest();
			builder.RegisterType<PrevisaoTempoBizService>().AsImplementedInterfaces().InstancePerRequest();
			builder.RegisterType<PrevisaoTempoEntityService>().AsImplementedInterfaces().InstancePerRequest();
			var container = builder.Build();

			//Configuração do server localhosto + porta
			var config = new HttpSelfHostConfiguration("http://localhost:3002");

			// Mapeamento da rota da controller
			config.Routes.MapHttpRoute(
				"API Default", "api/{controller}/{id}",
				new { id = RouteParameter.Optional });

			// Cors para permissão de chamada cruzada
			config.EnableCors(new EnableCorsAttribute("*", "*", "GET,POST,PUT,DELETE,PATCH,OPTIONS"));

			// Injeção das dependências no projeto
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
			// Inclusão do formato de retorno Bson (opcional) retornar binário para front
			config.Formatters.Add(new BsonMediaTypeFormatter());

			// Server Watch
			using (HttpSelfHostServer server = new HttpSelfHostServer(config))
			{
				server.OpenAsync().Wait();

				Console.WriteLine("Serviço rodando na porta http://localhost:3002/");
				Console.WriteLine("A aplicação Previsão Do Tempo está ativa!");
				Console.WriteLine("Press Enter to quit.");
				Console.ReadLine();
			}
			ConfigureService.Configure();
		}
	}
}