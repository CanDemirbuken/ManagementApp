using FluentValidation;
using ManagementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BusinessLayer.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name can not be null.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name can not be null.");
            RuleFor(x => x.CustomerNumber).NotEmpty().WithMessage("Customer Number can not be null.");
            RuleFor(x => x.MembershipLevel).NotEmpty().WithMessage("Membership Level can not be null.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone Level can not be null.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Level can not be null.");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Address Level can not be null.");
        }
    }
}
