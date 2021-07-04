using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class Theatre
    {
        [Key]
        public int TheatreId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string Email { get; set; }
        public Int64 MobileNo { get; set; }
        public string Password { get; set; }
        public string TheatreName { get; set; }
        public string Location { get; set; }
        public string LicenseId { get; set; }
        public bool Status { get; set; }
        public int LastAprrovalId { get; set; }
    }
}