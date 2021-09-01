using System;

namespace Assessment.Api.Models
{
    public class Calculation
    {
        public Calculation()
        {

        }
        public Calculation(Guid id)
        {
            Id = id;
            Status = new Status { Progress = 0, State = State.Running, Result = -1 };
        }
        public Guid Id { get; set; }
        public Status Status { get; set; }

    }
}
