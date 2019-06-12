using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        private static List<MovieModel> moviesList = new List<MovieModel>
        {
            new MovieModel
            {
                ID=1,
                MovieName = "The Avengers",
                Year=2012,
                Length="2h23min",
                TicketPrice=6
            },
            new MovieModel
            {
                ID=2,
                MovieName="The Avengers : Age of Ultron",
                Year = 2015,
                Length="2h21min",
                TicketPrice=7
            },
            new MovieModel
            {
                ID=3,
                MovieName = "The Avengers : Infinity War",
                Year=2018,
                Length="2h29min",
                TicketPrice=8
            },
            new MovieModel
            {
                ID = 4,
                MovieName="The Avengers : End Game",
                Year=2019,
                Length="3h1min",
                TicketPrice=9
            },
            new MovieModel
            {
                ID=5,
                MovieName="Iron Man",
                Year=2008,
                Length="2h6min",
                TicketPrice=6
            }
        };

        public IActionResult Index()
        {
            return View(moviesList);
        }

        public IActionResult MovieDetails(int id)
        {
            var movie= moviesList.FirstOrDefault(x => x.ID == id);
            return View(movie);
        }
        public IActionResult Edit(int id)
        {
            var movie = moviesList.FirstOrDefault(x => x.ID == id);
            return View(movie);
        }

        [HttpPost]
        [Route("FoundIt")]
        public IActionResult SaveChanges(MovieModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Edit");
            }
           
            var index = moviesList.FindIndex(x => x.ID == model.ID);
            moviesList[index] = model;
            return View("Index", moviesList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MovieModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            moviesList.Add(model);
            return View("Index", moviesList);
        }

        public IActionResult Delete(int id)
        {
            var movie = moviesList.FirstOrDefault(x => x.ID == id);
            moviesList.Remove(movie);
            return View("Index", moviesList);
        }
    }
}