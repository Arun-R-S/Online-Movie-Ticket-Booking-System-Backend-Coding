using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class TheatreSchedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public int TheatreId { get; set; }
        public int ScreenId { get; set; }
        public int MovieId { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime ShowTime { get; set; }
        public double SilverPrice { get; set; }
        public double GoldPrice { get; set; }
        public double PlatinumPrice { get; set; }
    }
}