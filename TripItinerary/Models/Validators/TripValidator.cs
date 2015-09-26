using FluentValidation;

namespace TripItinerary.Models.Validators
{
    public class TripValidator: AbstractValidator<Trip>
    {
        public TripValidator()
        {
            RuleFor(trip => trip.Name).NotEmpty();
        }
    }

}
