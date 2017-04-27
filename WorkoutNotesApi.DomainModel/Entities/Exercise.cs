namespace WorkoutNotesApi.DomainModel.Entities
{
    public class Exercise : Entity
    {
        public LocalizedProperty Name { get; set; }

        public int NameId { get; set; }

        public Muscle Muscle { get; set; }

        public int MuscleId { get; set; }
    }
}