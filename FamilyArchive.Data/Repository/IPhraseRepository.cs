namespace FamilyArchive.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public interface IPhraseRepository
    {
        void AddPhrase(Phrase phrase);

        void DeletePhrase(Phrase phrase);

        Task<Phrase> GetPhraseOrDefaultAsync(Guid guid);

        Task<IEnumerable<Phrase>> GetAllPhrasesAsync();
    }
}