using FluentValidation;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Security
{
    public class EmpleadoValidador : AbstractValidator<Empleado>
    {
        public EmpleadoValidador()
        {
            RuleFor(x => x.Id_Empl).NotNull();
            RuleFor(x => x.Nom_Ape).Length(20).NotEmpty();
            RuleFor(x => x.Cargo).Length(20).NotEmpty();
            RuleFor(x => x.Cuit).Length(12).NotEmpty();
            RuleFor(x => x.Dir).Length(20).NotEmpty();
            RuleFor(x => x.Tel).Length(14).NotEmpty();
            RuleFor(x => x.Mail).Length(50).EmailAddress().NotEmpty();
        }
    }
}
