using FluentValidation;
using ModeloDDD.Domain.Interfaces.Entities;
using ModeloDDD.Domain.Interfaces.Repositories;
using ModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Application.Services
{
    public class UsuarioService : IUsuarioService<IUsuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public int Add<TValidator>(IUsuario entity) where TValidator : AbstractValidator<IUsuario>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());

            return _usuarioRepository.Insert(entity);
        }

        public int Update<TValidator>(IUsuario entity) where TValidator : AbstractValidator<IUsuario>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());

            return _usuarioRepository.Update(entity);
        }

        public int Delete(int id)
        {
            return _usuarioRepository.Delete(id);
        }

        public IList<IUsuario> Get()
        {
            return _usuarioRepository.Select();
        }

        public IUsuario GetById(int id)
        {
            return _usuarioRepository.Select(id);
        }

        private void Validate(IUsuario entity, AbstractValidator<IUsuario> validator)
        {
            if (entity == null)
            {
                throw new Exception("Registros não detectados!");
            }

            validator.ValidateAndThrow(entity);
        }
    }
}
