namespace WorkoutNotesApi.DomainModel.Entities
{
    public class Translation : Entity
    {
        public MultiLanguageString MultiLanguageString { get; set; }

        public int MultiLanguageStringId { get; set; }

        public string Value { get; set; }

        public string LanguageName { get; set; }
    }
}