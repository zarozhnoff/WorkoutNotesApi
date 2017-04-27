namespace WorkoutNotesApi.DomainModel.Entities
{
    public class Exercise : Entity
    {
        public LocalizedString Name { get; set; }

        public int NameId { get; set; }

        public LocalizedString Description { get; set; }

        public int DescriptionId { get; set; }

        public Muscle Muscle { get; set; }

        public int MuscleId { get; set; }
    }
}