using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    public class RatingRepository : BaseRepository<RatingEntity>, IConcreteRepository<RatingEntity>
    {
        public RatingRepository(string Cnstr): base(Cnstr)
        {

        }

       
        public List<RatingEntity> Get()
        {
            throw new NotImplementedException();
        }
        public List<RatingEntity> GetByMovie(int idMovie)
        {
            string requete = @"SELECT  IdMovie, IdUser, Score, DateRating
                                FROM
                                Rating WHERE IdMovie="+ idMovie;
            return base.Get(requete);
        }

        public List<RatingEntity> GetByUser(int idUser)
        {
            string requete = @"SELECT  IdMovie, IdUser, Score, DateRating
                                FROM
                                Rating WHERE IdUser=" + idUser;
            return base.Get(requete);
        }

        public RatingEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

       

        public bool Insert(RatingEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(RatingEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(RatingEntity toDelete)
        {
            throw new NotImplementedException();
        }

    }
}
