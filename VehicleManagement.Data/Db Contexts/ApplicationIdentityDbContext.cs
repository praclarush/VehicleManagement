using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement.Data
{
	public class ApplicationIdentityDbContext : IdentityDbContext
	{
		public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options)
			: base(options)
		{
		}
	}
}
