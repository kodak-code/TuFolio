using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using DTO;
using BE;

namespace Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Autenticacion
            CreateMap<Auth, AuthDTO>()
                .ForMember(destino =>
                    destino.UsuarioNombre,
                    opt => opt.MapFrom(origen => origen.Usuario.Nombre)
                )
                .ForMember(destino =>
                    destino.BloqueoHasta,
                    opt => opt.MapFrom(origen => origen.BloqueoHasta.HasValue ? origen.BloqueoHasta.Value.ToString("dd/MM/yyyy") : null)
                )
                .ReverseMap()
                .ForMember(destino =>
                    destino.Usuario,
                    opt => opt.Ignore()
                );
            #endregion


            #region Usuario
            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(destino =>
                    destino.FechaCreacion,
                    opt => opt.MapFrom(origen => origen.FechaCreacion.ToString("dd/MM/yyyy"))
                )
                .ForMember(destino =>
                    destino.Activo,
                    opt => opt.MapFrom(origen => origen.Activo == true ? 1 : 0)
                )
                .ForMember(destino =>
                    destino.Verificado,
                    opt => opt.MapFrom(origen => origen.Verificado == true ? 1 : 0)
                )
                .ForMember(destino =>
                    destino.SubDivisionNombre,
                    opt => opt.MapFrom(origen => origen.SubDivisionNavigation == null ? null : origen.SubDivisionNavigation.Nombre)
                )
                .ReverseMap()
                .ForMember(destino =>
                    destino.Activo,
                    opt => opt.MapFrom(origen => origen.Activo == 1 ? true : false)
                )
                .ForMember(destino =>
                    destino.Verificado,
                    opt => opt.MapFrom(origen => origen.Verificado == 1 ? true : false)
                );
            #endregion

            #region Rol
            CreateMap<Rol, RolDTO>()
                .ReverseMap()
                .ForMember(destino =>
                    destino.UsuarioRols,
                    opt => opt.Ignore()
                );
                
            #endregion
        }
    }
}
