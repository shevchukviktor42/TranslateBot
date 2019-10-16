using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateBot.Models;

namespace TranslateBot.Repositories
{
    public interface IRepository
    {
        IEnumerable<Phrase> GetAll();
        Phrase Get(string str);
        bool Exists(string str);
        void Add(Phrase phrase);
        void Update(Phrase phrase);
        void Remove(Phrase phrase);

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
