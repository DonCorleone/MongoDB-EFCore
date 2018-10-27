using Blueshift.EntityFrameworkCore.MongoDB.Annotations;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using NotebookAppApi.Model;

namespace NotebookAppApi.Data
{
    [MongoDatabase("zooDb")]
    public class ZooDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ZooDbContext()
            : this(new DbContextOptions<ZooDbContext>())
        {
        }

        public ZooDbContext(DbContextOptions<ZooDbContext> zooDbContextOptions)
            : base(zooDbContextOptions)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var connectionString = "mongodb://localhost";
        //     //optionsBuilder.UseMongoDb(connectionString);

        //     var mongoUrl = new MongoUrl(connectionString);
        //     //optionsBuilder.UseMongoDb(mongoUrl);

        //     MongoClientSettings settings = MongoClientSettings.FromUrl(mongoUrl);
        //     //settings.SslSettings = new SslSettings
        //     //{
        //     //    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
        //     //};
        //     //optionsBuilder.UseMongoDb(settings);

        //     MongoClient mongoClient = new MongoClient(settings);
        //     optionsBuilder.UseMongoDb(mongoClient);
        // }
    }  
}  
