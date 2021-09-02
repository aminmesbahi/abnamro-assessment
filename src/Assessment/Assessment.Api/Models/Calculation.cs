using System;

namespace Assessment.Api.Models
{
    public class Calculation
    {
        public Calculation()
        {

        }
        public Calculation(Guid id, int inputValue)
        {
            Id = id;
            InputValue = inputValue;
            Status = new Status { Progress = 0, State = State.Running.ToDescriptionString(), Result = -1 };
        }
        public Guid Id { get; set; }
        public int InputValue {  get; set; }
        public Status Status { get; set; }

    }
}
