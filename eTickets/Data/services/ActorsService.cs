using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

       public void Add(Actor actor)
        {
            _context.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var ListOfActors = await _context.Actors.ToListAsync();
            return ListOfActors;
        }

       public  Actor GetById(int id)
        {
            var result=_context.Actors.FirstOrDefault(n=>n.ActorId==id);
            return result;
        }

       public Actor Upadate(int id, Actor newActor)
        {
           _context.Update(newActor);
            _context.SaveChanges();
            return newActor;
        }

    }
}
