using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Models
{
    public enum State
    {
        Running,
        Failed,
        Completed
    }
    public class StatusObject
    {
        public State State { get; set; }
        public int Progress { get; set; }
        public int Result { get; set; }
    }
}
