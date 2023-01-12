using Xeptions;

namespace Sheenam.Api.Model.Foundation.Guests.Exception;

public class GuestValidationException : Xeption
{
    public GuestValidationException(Xeption innerException)
        :base(message:"Guest validation error occured, fix it and try again", 
            innerException)
    { }
        
}