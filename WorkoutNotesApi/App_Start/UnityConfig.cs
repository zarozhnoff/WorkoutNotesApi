using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WorkoutNotesApi.DAL;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.Foundation.Interfaces;
using WorkoutNotesApi.Foundation.Muscles;
using WorkoutNotesApi.Foundation.Trainings;

namespace WorkoutNotesApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IApplicationUnitOfWorkFactory, ApplicationUnitOfWorkFactory>();
            container.RegisterType<ITrainingTrackingService, TrainingTrackingService>();
            container.RegisterType<IMuscleTrackingService, MuscleTrackingService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}