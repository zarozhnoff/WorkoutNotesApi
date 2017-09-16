using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WorkoutNotes.Foundation.Muscles;
using WorkoutNotes.Foundation.Trainings;
using WorkoutNotes.Repositories;
using WorkoutNotes.Repositories.Interfaces;

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