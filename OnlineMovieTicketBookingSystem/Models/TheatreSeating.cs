using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class TheatreSeating
    {
        [Key]
        public int SeatingId { get; set; }
        public int TheatreId { get; set; }
        public int ScreenNumber { get; set; }
        public int TotalRow { get; set; }
        public int TotalColumn { get; set; }
        public int FromSilver { get; set; }
        public int ToSilver { get; set; }
        public int FromGold { get; set; }
        public int ToGold { get; set; }
        public int FromPlatinum { get; set; }
        public int ToPlatinum { get; set; }
    }
}