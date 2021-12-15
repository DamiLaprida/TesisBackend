using FluentValidation;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Security
{
    public class UsuarioValidador : AbstractValidator<Usuario>
    {
        public UsuarioValidador()
        {
            RuleFor(x => x.Id_Usuario).NotNull();
            RuleFor(x => x.Id_Emp).NotNull();
            RuleFor(x => x.Nom_Usuario).NotEmpty().WithMessage("Usuario requerido");
            RuleFor(x => x.Contraseña).NotEmpty().WithMessage("Contraseña requerida");
        }
    }
}
