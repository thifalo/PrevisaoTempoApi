namespace PrevisaoTempo.Api
{
	using Topshelf;

	internal static class ConfigureService
	{
		internal static void Configure()
		{
			HostFactory.Run(configure =>
			{
				configure.Service<PrevisaoTempoServico>(service =>
				{
					service.ConstructUsing(s => new PrevisaoTempoServico());
					service.WhenStarted(s => s.Start());
					service.WhenStopped(s => s.Stop());
				});

				//Setup para API rodar como serviço (TopShelf)
				configure.RunAsLocalSystem();
				configure.SetServiceName("PrevisaoTempoBackEnd");
				configure.SetDisplayName("PrevisaoTempoBackEnd");
				configure.SetDescription("Previsão Tempo Serviço");
			});
		}
	}
}
