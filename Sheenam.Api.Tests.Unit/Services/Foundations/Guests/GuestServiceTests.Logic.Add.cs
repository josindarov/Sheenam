using System.Threading.Tasks;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Sheenam.Api.Brokers.Foundation.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests;

public partial class GuestServiceTests
{
    [Fact]
    public async Task ShouldAddGuestAsync()
    {
        // Given
        Guest randomGuest = CreateRandomGuest();
        Guest inputGuest = randomGuest;
        Guest returningGuest = inputGuest;
        Guest expectationGuest = returningGuest.DeepClone();

        this.storageBrokerMock.Setup(broker =>
            broker.InsertGuestAsync(inputGuest))
            .ReturnsAsync(returningGuest);

        // When
        Guest actualGuest =
            await this.guestService.AddGuestAsync(inputGuest);

        // Then
        actualGuest.Should().BeEquivalentTo(expectationGuest);
        
        this.storageBrokerMock.Verify(broker => 
            broker.InsertGuestAsync(inputGuest),
            Times.Once);
        
        this.storageBrokerMock.VerifyNoOtherCalls();
    }
}