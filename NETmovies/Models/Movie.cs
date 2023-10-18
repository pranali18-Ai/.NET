using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETmovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int RentalRate { get; set; }
    }
}