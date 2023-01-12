using Xeptions;

namespace Sheenam.Api.Model.Foundation.Guests.Exception;

public class NullGuestException : Xeption
{
    public NullGuestException()
    :base(message:"Guest is null")
    { }
}