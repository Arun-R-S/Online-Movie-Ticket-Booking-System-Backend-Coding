using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class PosterImageData
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public byte[] PosterData { get; set; }
    }
}