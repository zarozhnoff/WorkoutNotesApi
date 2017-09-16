using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace WorkoutNotes.DomainModel.Entities
{
    public class Role : Entity, IRole<int>
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}