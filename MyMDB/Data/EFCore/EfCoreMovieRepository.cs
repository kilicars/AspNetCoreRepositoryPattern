using MyMDB.Models;
using MyMDB.Models.EFCore;

namespace MyMDB.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyMDBContext>
    {
        public EfCoreMovieRepository(MyMDBContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
