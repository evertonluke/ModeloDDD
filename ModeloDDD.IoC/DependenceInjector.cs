using ModeloDDD.Application.Services;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Interfaces.Entities;
using ModeloDDD.Domain.Interfaces.Repositories;
using ModeloDDD.Domain.Interfaces.Services;
using ModeloDDD.Infra.Data.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ModeloDDD.IoC
{
    public class DependenceInjector
    {
        public static void Registrar()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Options.ResolveUnregisteredConcreteTypes = true;

            //// Register your types, for instance:
            container.Register<IUsuario, Usuario>(Lifestyle.Scoped);
            //container.Register<IUsuarioDto, UsuarioDto>(Lifestyle.Scoped);
            //container.Register<IUsuarioApplication, UsuarioApplication>(Lifestyle.Scoped);
            container.Register<IUsuarioService<IUsuario>, UsuarioService>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);

            //container.Register<MapperProvider, MapperProvider>();

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //// Automapper
            //container.RegisterSingleton(() => GetMapper(container));

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        //private static IMapper GetMapper(Container container)
        //{
        //    var mp = container.GetInstance<MapperProvider>();

        //    return mp.GetMapper();
        //}
    }
}
