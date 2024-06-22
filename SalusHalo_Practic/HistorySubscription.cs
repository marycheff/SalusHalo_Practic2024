using System;

namespace SalusHalo_Practic
{
    internal class HistorySubscriptions
    {
        public int Id { get; set; }
        public int VisitorId { get; set; }
        public DateTime EndTime { get; set; }
        public int NumOfSessions { get; set; }
        public int NumOfVisits { get; set; }
        public int RemainingVisits { get; set; }
        public string Status { get; set; }
    }
}
