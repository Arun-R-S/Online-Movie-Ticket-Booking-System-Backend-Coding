using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class AdminApproval
    {
        [Key]
        public int ApprovalId { get; set; }
        public int TheatreId { get; set; }
        public bool Approval { get; set; }
    }
}