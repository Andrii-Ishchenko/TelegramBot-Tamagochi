namespace Tamagochi.DAL
{
	using System;
	using System.Data.Entity;
	using System.Linq;
	using Domain;

	public class TamagochiDbContext : DbContext
	{
		// Your context has been configured to use a 'TamagochiModel' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'Tamagochi.DAL.TamagochiModel' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'TamagochiModel' 
		// connection string in the application configuration file.
		public TamagochiDbContext()
			: base("name=Tamagochi")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		 public virtual DbSet<Pet> Pets { get; set; }
		 public virtual DbSet<Activity> Activities { get; set; } 

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
        }
	}

}