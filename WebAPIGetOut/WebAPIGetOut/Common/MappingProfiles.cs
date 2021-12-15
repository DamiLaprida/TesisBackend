using AutoMapper;
using WebAPIGetOut.Domain;
using WebAPIGetOut.Domain.DTOs;

namespace WebAPIGetOut.Common
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Mappings
            
            CreateMap<Empleado, EmpleadoDTO>().ReverseMap();
            CreateMap<Producto, ProductoDTO>().ReverseMap();
            CreateMap<Recibo, ReciboDTO>().ReverseMap();    
            CreateMap<ReciboProducto, ReciboProductoDTO>().ReverseMap();
            CreateMap<Reserva, ReservaDTO>().ReverseMap();
            CreateMap<ReservaEmpleado, ReservaEmpleadoDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
