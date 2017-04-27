namespace WorkoutNotesApi.DomainModel.Entities
{
    public class TranslationItem : Entity
    {
        public LocalizedString Parent { get; set; }

        public int ParentId { get; set; }

        public string Value { get; set; }

        public string LanguageName { get; set; }
    }
}