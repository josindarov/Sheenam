using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Brokers.Foundation.Guests;

namespace Sheenam.Api.Brokers.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
