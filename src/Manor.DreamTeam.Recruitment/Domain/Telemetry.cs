using System;

namespace Manor.DreamTeam.Recruitment.Domain
{
    public class Telemetry
    {
        public IComparable<Guid> Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Lap Lap { get; set; }
        public Car Car { get; set; }
    }
}