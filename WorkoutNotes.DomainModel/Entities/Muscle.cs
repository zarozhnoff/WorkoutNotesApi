using System.Collections.Generic;

namespace WorkoutNotes.DomainModel.Entities
{
    public class Muscle : ExternalEntity
    {
        public MultiLanguageString Name { get; set; }

        public int NameId { get; set; }

        public int SortOrder { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}