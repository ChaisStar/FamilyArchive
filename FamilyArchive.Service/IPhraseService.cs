namespace FamilyArchive.Service
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public interface IPhraseService
    {
        Task AddPhraseAsync(string from, string to, string text);

        Task DeletePhraseAsync(Guid phraseGuid);

        Task<IEnumerable<Phrase>> GetAllPhrasesAsync();
    }
}