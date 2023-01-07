using System;
using System.Threading.Tasks;
using FluentAssertions;
using Sheenam.Api.Brokers.StorageBroker;
using Moq;
using Sheenam.Api.Brokers.Foundation.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests;

public class GuestServiceTests
{
    private readonly Mock<IStorageBroker> storageBrokerMock;
    private readonly GuestService guestService;

    public GuestServiceTests()
    {
        this.storageBrokerMock = new Mock<IStorageBroker>();

        this.guestService =
            new GuestService(storageBroker: this.storageBrokerMock.Object);
    }

    [Fact]
    public async Task ShouldAddGuestAsync()
    {
        Guest randomGuest = new Guest() {
            Id = Guid.NewGuid(),
            FirstName = "Murod",
            LastName = "Sindarov",
            Email = "mock@gmail.com",
            Address = "Sirdaryo region",
            DateOfBirth = DateTimeOffset.Now,
            Gender = GenderType.Male,
            PhoneNumber = "12345"
        };
        
        this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest))
            .ReturnsAsync(randomGuest);
        
        Guest actual = await this.guestService.
            AddGuestAsync(randomGuest);
        
        actual.Should().BeEquivalentTo(randomGuest);
    }
}