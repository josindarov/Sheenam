using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace Sheenam.Api.Brokers.StorageBroker;

public partial class StorageBroker : EFxceptionsContext
{
    private readonly IConfiguration configuration;

    public StorageBroker(IConfiguration _configuration)
    {
        this.configuration = _configuration;
        this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = 
            this.configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString);
    }

    public override void Dispose() { }
}