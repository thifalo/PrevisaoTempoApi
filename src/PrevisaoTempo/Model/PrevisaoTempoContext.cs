namespace PrevisaoTempo.Model
{
	using System.Data.Entity;

	// Esqueleto para configuração do banco de dados (não necessário para o projeto)
	public class PrevisaoTempoContext : DbContext
	{
		public PrevisaoTempoContext(DbContext options)
			: base()
		{
		}

		public DbSet<CidadeTo> Cidades { get; set; }
	}
}
