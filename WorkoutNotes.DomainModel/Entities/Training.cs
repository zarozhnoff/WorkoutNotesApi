using System;
using System.Collections.Generic;

namespace WorkoutNotes.DomainModel.Entities
{
    public class Training : ExternalEntity
    {
        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public DateTime CreationDate { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public ICollection<Muscle> Muscles { get; set; }
    }
}