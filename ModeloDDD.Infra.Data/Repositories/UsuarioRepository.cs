using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Interfaces.Entities;
using ModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(IUsuario entity)
        {
            throw new NotImplementedException();
        }

        public IList<IUsuario> Select()
        {
            throw new NotImplementedException();
        }

        public IUsuario Select(int id)
        {
            return new Usuario
            {
                Id = 1,
                Name = "Everton Luke Honorato",
                Email = "everton.luke@reval.net",
                Password = "12345678"
            };
        }

        public int Update(IUsuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
