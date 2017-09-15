using Microsoft.AspNet.Identity;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Roles
{
    public sealed class ApplicationRoleManager : RoleManager<Role, int>
    {
        public ApplicationRoleManager(IRoleStore<Role, int> store) : base(store)
        {
        }
    }
}