using System;
using System.Runtime.Serialization;

namespace WorkoutNotesApi.Controllers.DataContracts
{
    [DataContract]
    public class MuscleDataContract
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int SortOrder { get; set; }
    }
}