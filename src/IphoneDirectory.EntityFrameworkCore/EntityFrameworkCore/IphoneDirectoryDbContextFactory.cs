using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IphoneDirectory.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class IphoneDirectoryDbContextFactory : IDesignTimeDbContextFactory<IphoneDirectoryDbContext>
{
    public IphoneDirectoryDbContext CreateDbContext(string[] args)
    {
        IphoneDirectoryEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IphoneDirectoryDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new IphoneDirectoryDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../IphoneDirectory.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
