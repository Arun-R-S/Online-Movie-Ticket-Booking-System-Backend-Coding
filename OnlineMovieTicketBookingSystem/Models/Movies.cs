using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMovieTicketBookingSystem.Models
{
    [Table("Movies")]
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string PosterImage { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public object GetAllMovies()
        {
            ProjectContext db = new ProjectContext();
            return db.Movies.OrderBy(d => d.MovieName);
        }
        public object GetNewReleases()
        {
            ProjectContext db = new ProjectContext();
            return db.Movies.OrderByDescending(d => d.ReleaseDate).Take(3);
        }

        public object GetTopRatedMovies()
        {
            ProjectContext db = new ProjectContext();
            return db.Movies.OrderByDescending(d => d.Rating).Take(6);
        }
    }
   
}