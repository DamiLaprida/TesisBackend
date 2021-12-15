using FluentValidation;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Security
{
    public class ReciboValidador : AbstractValidator<Recibo>
    {
        public ReciboValidador()
        {
            RuleFor(x => x.Id_Recibo).NotNull();
            RuleFor(x => x.Total).NotEmpty();
            RuleFor(x => x.Fecha_Emi).NotEmpty();
        }
    }
}
