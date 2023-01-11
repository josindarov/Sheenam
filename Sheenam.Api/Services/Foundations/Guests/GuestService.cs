using Sheenam.Api.Brokers.Foundation.Guests;
using Sheenam.Api.Brokers.StorageBroker;

namespace Sheenam.Api.Services.Foundations.Guests;

public class GuestService : IGuestService
{
    private readonly IStorageBroker storageBroker;

    public GuestService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }
    
    public ValueTask<Guest> AddGuestAsync(Guest guest)
    {
        return this.storageBroker.InsertGuestAsync(guest);
    }
}