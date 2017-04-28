using System.Collections.Generic;

namespace WorkoutNotesApi.DomainModel.Entities
{
    public class Muscle : Entity
    {
        public LocalizedString Name { get; set; }

        public int NameId { get; set; }

        public ushort SortOrder { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}