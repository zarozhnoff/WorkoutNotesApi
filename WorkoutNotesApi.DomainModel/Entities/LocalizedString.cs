using System.Collections.Generic;

namespace WorkoutNotesApi.DomainModel.Entities
{
    public class LocalizedString : Entity
    {
        public string DefaultValue { get; set; }

        public ICollection<TranslationItem> Translations { get; set; }
    }
}