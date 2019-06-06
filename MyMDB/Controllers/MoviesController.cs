using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyMDB.Data.EFCore;
using MyMDB.Models;

namespace MyMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
