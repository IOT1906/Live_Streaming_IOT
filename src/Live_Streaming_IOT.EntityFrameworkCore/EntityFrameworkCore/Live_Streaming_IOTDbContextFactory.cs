using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Live_Streaming_IOT.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Live_Streaming_IOTDbContextFactory : IDesignTimeDbContextFactory<Live_Streaming_IOTDbContext>
{
    public Live_Streaming_IOTDbContext CreateDbContext(string[] args)
    {
        Live_Streaming_IOTEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Live_Streaming_IOTDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Live_Streaming_IOTDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Live_Streaming_IOT.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
