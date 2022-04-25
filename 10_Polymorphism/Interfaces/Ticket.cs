using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set;}

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }


        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;

        }
    }
}
