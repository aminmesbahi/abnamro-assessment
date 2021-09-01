using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Api.Models
{
    public enum State
    {
        Running,
        Failed,
        Completed
    }
    public class Status
    {
        public State State { get; set; }
        public int Progress { get; set; }
        public int Result { get; set; }
    }
}