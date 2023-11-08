using ModeloDDD.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        int Insert(TEntity entity);

        int Update(TEntity entity);

        int Delete(int id);

        IList<TEntity> Select();

        TEntity Select(int id);
    }
}
