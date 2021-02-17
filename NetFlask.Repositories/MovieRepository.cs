using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFlask.DAL.Repositories;
using NetFlask.Entities;

namespace NetFlask.Repositories
{
    public class MovieRepository : BaseRepository<MovieEntity>, IConcreteRepository<MovieEntity>
    {
        public MovieRepository(string cnstr): base(cnstr)
        {

        }

        public bool Delete(MovieEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MovieEntity> Get()
        {
            string requete = "Select * from V_Rating";

            return base.Get(requete);
        }

        public List<MovieEntity> GetFromGenres(int idGenre)
        {
            string requete = @"Select Movie.* from Movie 
                               inner join MovieGenre
                               ON Movie.IdMovie = MovieGEnre.IdGenre
                                WHERE MovieGenre.IdGenre=" + idGenre;
            return base.Get(requete);
        }

        public MovieEntity GetOne(int PK)
        {
            string requete = "Select * from V_Rating where IdMovie = @id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(MovieEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(MovieEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
