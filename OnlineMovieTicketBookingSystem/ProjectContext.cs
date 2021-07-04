using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace OnlineMovieTicketBookingSystem
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            : base("name=omtbs1")
        {
        }

        public virtual DbSet<Models.Movies> Movies{get;set;}
        public virtual DbSet<Models.PosterImageData> PosterImageDatas { get; set; }
        public virtual DbSet<Models.AdminApproval> AdminApprovals { get; set; }
        public virtual DbSet<Models.BookingDetails> BookingDetails { get; set; }
        public virtual DbSet<Models.Customer> Customers { get; set; }
        public virtual DbSet<Models.Subscription> Subscriptions { get; set; }
        public virtual DbSet<Models.Theatre> TheatreAdmins { get; set; }
        public virtual DbSet<Models.TheatreSchedule> TheatreSchedules { get; set; }
        public virtual DbSet<Models.TheatreSeating> TheatreSeatings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}