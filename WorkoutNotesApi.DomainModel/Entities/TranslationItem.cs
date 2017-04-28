namespace WorkoutNotesApi.DomainModel.Entities
{
    public class TranslationItem : Entity
    {
        public LocalizedString LocalizedString { get; set; }

        public int LocalizedStringId { get; set; }

        public string Value { get; set; }

        public string LanguageName { get; set; }
    }
}