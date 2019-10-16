using System;
using System.Collections.Generic;
using System.Text;

namespace homeapp2.Shared
{
    public class FormattedLeg
    {
        public List<FormattedTrip> Trips { get; set; } = new List<FormattedTrip>();
        public string Duration { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
