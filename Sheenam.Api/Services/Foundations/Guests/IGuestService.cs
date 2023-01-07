using Sheenam.Api.Brokers.Foundation.Guests;

namespace Sheenam.Api.Services.Foundations.Guests;

public interface IGuestService
{
    ValueTask<Guest> AddGuestAsync(Guest guest);
}