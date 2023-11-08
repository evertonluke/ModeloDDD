using FluentValidation;
using ModeloDDD.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {
        int Add<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;

        int Update<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;

        int Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);
    }
}
