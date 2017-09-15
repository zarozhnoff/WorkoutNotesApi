using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace WorkoutNotesApi.DomainModel.Entities
{
    public class User : Entity, IUser<int>
    {
        public string UserName { get; set; }

        public Gender? Gender { get; set; }

        public DateTime JoinDate { get; set; }

        public ICollection<Role> Roles { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}