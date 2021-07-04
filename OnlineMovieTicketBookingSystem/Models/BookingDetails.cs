using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingId { get; set; }
        public int ScheduleId { get; set; }
        public string CustomerId { get; set; }
        public string BookedSeats { get; set; }
        public int BookedSilver { get; set; }
        public int BookedGold { get; set; }
        public int BookedPlatinum { get; set; }
        public int TotalPrice { get; set; }

    }
}