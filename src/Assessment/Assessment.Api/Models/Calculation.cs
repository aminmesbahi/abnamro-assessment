using System;

namespace Assessment.Api.Models
{
    public class Calculation
    {
        public Calculation()
        {

        }
        public Calculation(Guid id, int inputValue, string conId)
        {
            Id = id;
            InputValue = inputValue;
            ConId = conId;  
            Status = new Status { Progress = 0, State = State.Running.ToDescriptionString(), Result = -1 };
        }
        public Guid Id { get; set; }
        public int InputValue {  get; set; }
        public Status Status { get; set; }
        public string ConId { get; set; }

    }
    public class CalculationRequestModel
    {
        public int RequestValue { get; set; }

        public string ConId { get; set; }
    }
}
