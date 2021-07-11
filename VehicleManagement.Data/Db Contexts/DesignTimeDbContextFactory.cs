using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VehicleManagement.Data
{
	public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<VehicleManagementDbContext>
	{
		public VehicleManagementDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder().
				SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile(@Directory.GetCurrentDirectory() + "/../VehicleManagement/appsettings.json").Build();

			var builder = new DbContextOptionsBuilder<VehicleManagementDbContext>();
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			builder.UseSqlServer(connectionString);
			return new VehicleManagementDbContext(builder.Options);

		}
	}
}
