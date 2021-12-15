using FluentValidation;
using WebAPIGetOut.Domain;

namespace WebAPIGetOut.Security
{
    public class ProductoValidador : AbstractValidator<Producto>
    {
        public ProductoValidador()
        {
            RuleFor(x => x.Id_Prod).NotNull();
            RuleFor(x => x.Nombre).Length(50).WithMessage("Ingrese un nombre").NotEmpty();
            RuleFor(x => x.Lote).NotEmpty(); 
            RuleFor(x => x.Cantidad).NotEmpty();
            RuleFor(x => x.Pre_Uni).NotEmpty();
            RuleFor(x => x.Total).NotEmpty();
        }
    }
}
