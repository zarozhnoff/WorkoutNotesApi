using System;

namespace WorkoutNotes.DomainModel
{
    public class ExternalEntity : Entity
    {
        public Guid ExternalId { get; set; }
    }
}