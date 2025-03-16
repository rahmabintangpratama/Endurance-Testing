using System;

namespace Endurance_Testing.Models
{
    public class TestParameters
    {
        public string Url { get; set; }

        public int TotalRequests { get; set; }

        public int TimeoutInSeconds { get; set; }

        public long DurationInSeconds { get; set; }

        public string SelectedTimePeriod { get; set; }
    }
}