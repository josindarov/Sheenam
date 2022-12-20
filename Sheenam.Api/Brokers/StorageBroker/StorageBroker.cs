using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Brokers.Foundation.Guests;

namespace Sheenam.Api.Brokers.StorageBroker;

public partial class StorageBroker : EFxceptionsContext, IStorageBroker
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