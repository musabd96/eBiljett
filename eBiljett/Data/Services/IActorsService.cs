﻿using eBiljett.Models;

namespace eBiljett.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);

        void Add(Actor actor);
        Actor Update(int id, Actor actor);
        Actor Delete(int id);
    }
}
