using System.Collections.Generic;

namespace WorkoutNotesApi.DomainModel.Entities
{
    public class LocalizedString : Entity
    {
        public ICollection<TranslationItem> Translations { get; set; }
    }
}