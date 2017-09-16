namespace WorkoutNotes.DomainModel.Entities
{
    public class Exercise : ExternalEntity
    {
        public MultiLanguageString Name { get; set; }

        public int NameId { get; set; }

        public MultiLanguageString Description { get; set; }

        public int DescriptionId { get; set; }

        public Muscle Muscle { get; set; }

        public int MuscleId { get; set; }
    }
}