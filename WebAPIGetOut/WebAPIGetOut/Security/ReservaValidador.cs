using FluentValidation;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Security
{
    public class ReservaValidador : AbstractValidator<Reserva>
    {
        public ReservaValidador()
        {
            RuleFor(x => x.Id_Res).NotNull();
            RuleFor(x => x.Fecha_Act).NotEmpty();
            RuleFor(x => x.Fecha_Res).NotEmpty();
            RuleFor(x => x.Nro_Par).NotEmpty(); 
            RuleFor(x => x.Pago).NotEmpty();
            
        }
    }
}
