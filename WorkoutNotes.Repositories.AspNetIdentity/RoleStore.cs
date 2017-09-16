using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WorkoutNotes.DomainModel.Entities;

namespace WorkoutNotes.Repositories.AspNetIdentity
{
    public sealed class RoleStore : IRoleStore<Role, int>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(Role role)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Role role)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Role role)
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> FindByIdAsync(int roleId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> FindByNameAsync(string roleName)
        {
            throw new System.NotImplementedException();
        }
    }
}