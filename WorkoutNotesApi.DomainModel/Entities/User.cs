namespace WorkoutNotesApi.DomainModel.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public Gender? Gender { get; set; }
    }
}