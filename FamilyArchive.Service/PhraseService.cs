namespace FamilyArchive.Service
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data.Repository;
    using Model;

    public class PhraseService : IPhraseService
    {
        private readonly IPhraseRepository _phraseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PhraseService(IPhraseRepository phraseRepository, IUnitOfWork unitOfWork)
        {
            _phraseRepository = phraseRepository;
            _unitOfWork = unitOfWork;
        }

        public Task AddPhraseAsync(string from, string to, string text)
        {
            _phraseRepository.AddPhrase(new Phrase
            {
                Text = text,
                From = from,
                To = to
            });
            return _unitOfWork.SaveAsync();
        }

        public async Task DeletePhraseAsync(Guid phraseGuid)
        {
            var phrase = await _phraseRepository.GetPhraseOrDefaultAsync(phraseGuid);
            if (phrase == null)
                return;

            _phraseRepository.DeletePhrase(phrase);
            await _unitOfWork.SaveAsync();
        }

        public Task<IEnumerable<Phrase>> GetAllPhrasesAsync()
        {
            return _phraseRepository.GetAllPhrasesAsync();
        }
    }
}