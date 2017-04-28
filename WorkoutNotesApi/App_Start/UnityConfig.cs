using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WorkoutNotesApi.DAL;
using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IApplicationUnitOfWorkFactory, ApplicationUnitOfWorkFactory>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}