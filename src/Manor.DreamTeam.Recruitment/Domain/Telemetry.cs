using System;

namespace Manor.DreamTeam.Recruitment.Domain
{
    public class Telemetry : IComparable<Telemetry>
    {
        public IComparable Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Lap Lap { get; set; }
        public Car Car { get; set; }

        public int CompareTo(Telemetry other)
        {
            throw new NotImplementedException();
        }
    }
}