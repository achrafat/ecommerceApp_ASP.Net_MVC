using eTickets.Models;

namespace eTickets.Data.services
{
    public interface IActorsService
    {
        public Task<IEnumerable<Actor>> GetAll();
        public Actor GetById(int id);
        public void Add(Actor actor);
        public Actor Upadate(int id, Actor newActor);
        public void Delete(int id);
    }
}
