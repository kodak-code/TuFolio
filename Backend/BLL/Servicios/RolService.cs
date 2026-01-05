using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Servicios.Contrato;
using DAL.Repositorios.Contrato;
using DTO;
using BE;

namespace BLL.Servicios
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol> _rolRepo;
        private readonly IMapper _mapper;

        public RolService(IGenericRepository<Rol> rolRepo, IMapper mapper)
        {
            _rolRepo = rolRepo;
            _mapper = mapper;
        }

        public async Task<List<RolDTO>> Lista()
        {
            try
            {
                var listaRoles = await _rolRepo.Consultar();

                return _mapper.Map<List<RolDTO>>(listaRoles.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
