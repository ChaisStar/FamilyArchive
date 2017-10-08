namespace FamilyArchive.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class PhraseRepository : RepositoryBase<Phrase>, IPhraseRepository
    {
        public PhraseRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public void AddPhrase(Phrase phrase)
        {
            Add(phrase);
        }

        public void DeletePhrase(Phrase phrase)
        {
            Delete(phrase);
        }

        public Task<Phrase> GetPhraseOrDefaultAsync(Guid guid)
        {
            return DbSet.FirstOrDefaultAsync(x => x.Guid == guid);
        }

        public async Task<IEnumerable<Phrase>> GetAllPhrasesAsync()
        {
            return await DbSet.ToListAsync();
        }
    }
}