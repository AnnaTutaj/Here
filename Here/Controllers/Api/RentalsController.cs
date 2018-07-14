using Here.Dtos;
using Here.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Here.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRentals(RentalDto rental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == rental.CustomerId);

            var movies = _context.Movies.Where(
                m => rental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                var newRental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();
            return Ok();

        }
    }
}