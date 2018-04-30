namespace PrevisaoTempo.Tests
{
	using Autofac;
	using Service.BizService;
	using Service.EntityService;

	public abstract class BaseTests
	{
		protected IContainer Container { get; set; }

		public virtual void Setup()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<PrevisaoTempoBizService>().AsImplementedInterfaces().InstancePerLifetimeScope();
			builder.RegisterType<PrevisaoTempoEntityService>().AsImplementedInterfaces().InstancePerLifetimeScope();
			Container = builder.Build();
		}
	}
}
