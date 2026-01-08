using AutoMapper;
using BE;
using BLL.Servicios.Contrato;
using DAL.Repositorios.Contrato;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepo;
        private readonly IMapper _mapper;

        public UsuarioService(IGenericRepository<Usuario> usuarioRepo, IMapper mapper)
        {
            _usuarioRepo = usuarioRepo;
            _mapper = mapper;
        }

        public async Task<List<UsuarioDTO>> Listar()
        {
            try
            {
                var queryUsuarios = await _usuarioRepo.Consultar();

                var listaUsuarios = queryUsuarios
                    .Include(subDiv => subDiv.SubDivisionNavigation)
                        .ThenInclude(pais => pais.Pais)
                    .ToList();

                if (!listaUsuarios.Any())
                    throw new Exception("No hay usuarios registrados");

                return _mapper.Map<List<UsuarioDTO>>(listaUsuarios);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UsuarioDTO> Crear(UsuarioDTO modelo)
        {
            try
            {
                var usuarioCreado = await _usuarioRepo.Crear(_mapper.Map<Usuario>(modelo));

                if (usuarioCreado.Id == 0)
                    throw new TaskCanceledException("No se pudo crear");

                // devolver usuario creado
                var query = await _usuarioRepo.Consultar(usuario => usuario.Id == usuarioCreado.Id);

                usuarioCreado = query.First();

                return _mapper.Map<UsuarioDTO>(usuarioCreado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Editar(UsuarioDTO modelo)
        {
            try
            {
                var usuarioModelo = _mapper.Map<Usuario>(modelo);

                var usuarioEncontrado = await _usuarioRepo.Obtener(u => u.Id == usuarioModelo.Id);

                if (usuarioEncontrado == null)
                    throw new TaskCanceledException("El usuario no existe");

                usuarioEncontrado.Nombre = usuarioModelo.Nombre;
                usuarioEncontrado.Apellido = usuarioModelo.Apellido;
                usuarioEncontrado.Gmail = usuarioModelo.Gmail;
                usuarioEncontrado.SubDivision = usuarioModelo.SubDivision;

                bool respuesta = await _usuarioRepo.Editar(usuarioEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo editar");

                return respuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> Desactivar(int id)
        {
            try
            {
                var usuarioEncontrado = await _usuarioRepo.Obtener(u => u.Id == id);

                if (usuarioEncontrado == null)
                    throw new TaskCanceledException("El usuario no existe");

                usuarioEncontrado.Activo = false;

                bool respuesta = await _usuarioRepo.Editar(usuarioEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo editar");

                return respuesta;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
