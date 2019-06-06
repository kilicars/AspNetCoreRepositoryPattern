using Microsoft.AspNetCore.Mvc;
using MyMDB.Data.EFCore;
using MyMDB.Models;

namespace MyMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}