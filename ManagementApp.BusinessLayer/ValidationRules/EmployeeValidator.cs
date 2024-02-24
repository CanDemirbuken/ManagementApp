using FluentValidation;
using ManagementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BusinessLayer.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name can not be null.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name can not be null.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be null.");
            RuleFor(x => x.Department).NotEmpty().WithMessage("Department can not be null.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone Level can not be null.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Level can not be null.");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Salary can not be null.");
        }
    }
}
