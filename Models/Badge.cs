using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject02.Models
{
    public class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }

    public enum BadgeTier
    {
        Standard,
        VIP
    }
}
