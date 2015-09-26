using FluentValidation.Attributes;
using TripItinerary.Models.Validators;

namespace TripItinerary.Models
{
    [Validator(typeof(TripValidator))]
    public partial class Trip {}
}
