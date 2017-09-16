using Microsoft.AspNet.Identity;
using WorkoutNotes.DomainModel.Entities;

namespace WorkoutNotes.Foundation.Users
{
    public sealed class ApplicationUserManager : UserManager<User, int>
    {
        public ApplicationUserManager(IUserStore<User, int> store) : base(store)
        {
        }
    }
}