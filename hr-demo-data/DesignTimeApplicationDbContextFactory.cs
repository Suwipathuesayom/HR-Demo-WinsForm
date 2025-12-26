using System;
using System.IO;
using hr_demo_data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace crud_user_data
{
    public class DesignTimeApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

          
            string basePath = Directory.GetCurrentDirectory();
            string foundBasePath = null;
            var dir = new DirectoryInfo(basePath);
            while (dir != null)
            {
                var candidate = Path.Combine(dir.FullName, "appsettings.json");
                if (File.Exists(candidate))
                {
                    foundBasePath = dir.FullName;
                    break;
                }
                dir = dir.Parent;
            }

            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(foundBasePath ?? basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                .AddEnvironmentVariables();

            var configuration = configBuilder.Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

        
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = "Server=localhost;Database=CRUD_Company_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            }

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
