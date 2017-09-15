using System;

namespace WorkoutNotesApi.DomainModel
{
    public class ExternalEntity : Entity
    {
        public Guid ExternalId { get; set; }
    }
}