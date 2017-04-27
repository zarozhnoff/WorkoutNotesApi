namespace WorkoutNotesApi.DomainModel.Entities
{
    public class Muscle : Entity
    {
        public LocalizedProperty Name { get; set; }

        public int NameId { get; set; }

        public ushort SortOrder { get; set; }
    }
}