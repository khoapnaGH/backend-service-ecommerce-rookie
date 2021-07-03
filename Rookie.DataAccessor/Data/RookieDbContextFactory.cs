using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Rookie.DataAccessor.Data
{
    public class RookieDbContextFactory : IDesignTimeDbContextFactory<RookieDbcontext>
    {
        public RookieDbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("RookieDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<RookieDbcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new RookieDbcontext(optionsBuilder.Options);
        }
    }
}
