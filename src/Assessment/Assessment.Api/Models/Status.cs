using System.ComponentModel;

namespace Assessment.Api.Models
{
    public enum State
    {
        [Description("Running")]
        Running=0,
        [Description("Failed")]
        Failed=1,
        [Description("Completed")]
        Completed
    }

    public class Status
    {
        public string State { get; set; }
        public int Progress { get; set; }
        public int Result { get; set; }
    }
}