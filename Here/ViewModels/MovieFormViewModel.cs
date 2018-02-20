using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Here.Models;
using System.ComponentModel.DataAnnotations;

namespace Here.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }


        [Required]
        [Display(Name = "Added date")]
        public DateTime? CreatedAt { get; set; }

        [Required]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }


        [Display(Name = "Number in stock")]
        [Range(1, 30)]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;

        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            CreatedAt = movie.CreatedAt;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}