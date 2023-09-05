﻿using eTickets.Models;
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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var ListOfActors = await _context.Actors.ToListAsync();
            return ListOfActors;
        }

       public  Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

       public Actor Upadate(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

    }
}
