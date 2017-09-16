using Microsoft.AspNet.Identity;
using WorkoutNotes.DomainModel.Entities;

namespace WorkoutNotes.Foundation.Roles
{
    public sealed class ApplicationRoleManager : RoleManager<Role, int>
    {
        public ApplicationRoleManager(IRoleStore<Role, int> store) : base(store)
        {
        }
    }
}