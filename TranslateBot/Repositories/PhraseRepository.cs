using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateBot.Data;
using TranslateBot.Models;

namespace TranslateBot.Repositories
{
    public class PhraseRepository : IRepository
    {
        private readonly LocalDbContext context;
        public PhraseRepository(LocalDbContext context)
        {
            this.context = context;
        }

        public void Add(Phrase phrase)
        {
            context.Add(phrase);
            context.SaveChangesAsync();
        }

        public bool Exists(string str)
        {
            return context.Local.Any(x => x.src == str);
        }

        public Phrase Get(string str)
        {
           return context.Local.FirstOrDefault(x => x.src == str);
        }

        public IEnumerable<Phrase> GetAll()
        {
            return context.Local.ToList();
        }

      
        public void Remove(Phrase phrase)
        {
            context.Remove(phrase);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await context.SaveChangesAsync();
        }

        public void Update(Phrase phrase)
        {
            context.Update(phrase);
        }
    }
}
