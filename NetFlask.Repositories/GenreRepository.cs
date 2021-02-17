using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    public class GenreRepository : BaseRepository<GenreEntity>, IConcreteRepository<GenreEntity>
    {
        public GenreRepository(string connectionString): base(connectionString)
        {

        }
      

        public List<GenreEntity> Get()
        {
            throw new NotImplementedException();
        }

        public GenreEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }


        public List<GenreEntity> GetFromMovie(int idMovie)
        {
            string requete = @"Select Genre.* from Genre 
                               inner join MovieGenre
                               ON Genre.IdGenre = MovieGenre.IdGenre
                                WHERE MovieGenre.IdMovie=" + idMovie;
            return base.Get(requete);
        }

        public bool Insert(GenreEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(GenreEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(GenreEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
