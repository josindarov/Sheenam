using System.Threading.Tasks;
using Sheenam.Api.Brokers.Foundation.Guests;
using Sheenam.Api.Model.Foundation.Guests.Exception;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests;

public partial class GuestServiceTests
{
    [Fact]
    public async Task ShouldThrowValidationExceptionOnAddIfGuestIsNullLogItAsync()
    {
        // given
        Guest nullGuest = null;
        var nullGuestException = new NullGuestException();

        var expectedGuestValidationException = 
            new GuestValidationException(nullGuestException);

        // when
        ValueTask<Guest> addGuestTask =
            this.guestService.AddGuestAsync(nullGuest);
        // then
        await Assert.ThrowsAsync<GuestValidationException>(() =>
            addGuestTask.AsTask());
    }
    
}