using System.Collections.Generic;

namespace WorkoutNotes.DomainModel.Entities
{
    public class MultiLanguageString : Entity
    {
        public ICollection<Translation> Translations { get; set; }
    }
}