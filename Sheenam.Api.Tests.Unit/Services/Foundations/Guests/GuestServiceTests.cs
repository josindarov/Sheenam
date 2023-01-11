using System;
using Sheenam.Api.Brokers.StorageBroker;
using Moq;
using Sheenam.Api.Brokers.Foundation.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Tynamix.ObjectFiller;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests;

public partial class GuestServiceTests
{
    private readonly Mock<IStorageBroker> storageBrokerMock;
    private readonly GuestService guestService;

    public GuestServiceTests()
    {
        this.storageBrokerMock = new Mock<IStorageBroker>();

        this.guestService =
            new GuestService(storageBroker: this.storageBrokerMock.Object);
    }
    
    private static Guest CreateRandomGuest()
    {
        return CreateGuestFiller(date:
            GetRandomDateTimeOffSet()).Create();
    }

    private static DateTimeOffset GetRandomDateTimeOffSet()
    {
        return new DateTimeRange(earliestDate: 
            new DateTime()).GetValue();
    }
    
    private static Filler<Guest> CreateGuestFiller(DateTimeOffset date)
    {
        var filler = new Filler<Guest>();

        filler.Setup()
            .OnType<DateTimeOffset>().Use(date);

        return filler;
    }
}