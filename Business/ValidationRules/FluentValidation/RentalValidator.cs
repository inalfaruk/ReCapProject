using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {

        public RentalValidator()
        {
            RuleFor(p => p.RentDate).GreaterThanOrEqualTo(DateTime.Now);
            RuleFor(p => p.CustomerId).NotNull();
            RuleFor(p => p.CarId).NotNull();
            RuleFor(p => p.RentDate).NotNull();
            

        }


    }
}
