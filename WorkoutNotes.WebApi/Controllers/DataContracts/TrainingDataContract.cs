using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WorkoutNotes.WebApi.Controllers.DataContracts
{
    [DataContract]
    public class TrainingDataContract
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public ICollection<Guid> MuscleTypes { get; set; }
    }
}