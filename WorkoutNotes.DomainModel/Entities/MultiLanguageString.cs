using System.Collections.Generic;

namespace WorkoutNotesApi.DomainModel.Entities
{
    public class MultiLanguageString : Entity
    {
        public ICollection<Translation> Translations { get; set; }
    }
}