using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string Plan { get; set; }
        public DateTime Purchased{get;set;}
        public DateTime Expiry { get; set; }
        public double Price { get; set; }
    }
}