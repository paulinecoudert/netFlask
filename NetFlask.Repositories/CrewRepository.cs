using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    public class CrewRepository : BaseRepository<CrewEntity>, IConcreteRepository<CrewEntity>
    {
        public CrewRepository(string connectionString): base(connectionString)
        {

        }

        public List<CrewEntity> Get()
        {
            throw new NotImplementedException();
        }

        public CrewEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public List<CrewEntity> GetDirectors(int IdMovie)
        {
            //Attention : Directors is a VIEW
            //string requete=@"SELECT  Directors.IdCrew, Directors.FirstName, Directors.LastName, Directors.Job
            //                 FROM Directors INNER JOIN
            //                 CrewMovie ON Directors.IdCrew = CrewMovie.IdCrew
            //                 WHERE IdMovie = " + IdMovie  ;

            string requete = @"exec [GetDirectorFromMovie] " + IdMovie;

            return base.Get(requete);
        }

        public bool Insert(CrewEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(CrewEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CrewEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
