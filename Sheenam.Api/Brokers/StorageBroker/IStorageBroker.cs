using Sheenam.Api.Brokers.Foundation.Guests;

namespace Sheenam.Api.Brokers.StorageBroker;

public partial interface IStorageBroker
{
    ValueTask<Guest> InsertGuestAsync(Guest guest);
}