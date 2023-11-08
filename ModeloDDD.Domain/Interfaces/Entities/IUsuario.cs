using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Domain.Interfaces.Entities
{
    public interface IUsuario : IBaseEntity
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
