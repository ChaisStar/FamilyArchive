namespace FamilyArchive.Application.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dto;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using Service;

    [Route("api/[controller]")]
    public class PhraseController : Controller
    {
        private readonly IPhraseService _phraseService;

        public PhraseController(IPhraseService phraseService)
        {
            _phraseService = phraseService;
        }

        [HttpGet]
        public Task<IEnumerable<Phrase>> GetAllPhrases()
        {
            return _phraseService.GetAllPhrasesAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePhraseAsync([FromBody] CreatePhraseDto dto)
        {
            await _phraseService.AddPhraseAsync(dto.From, dto.To, dto.Text);
            return Ok();
        }

        [HttpDelete]
        [Route("{guid}")]
        public async Task<IActionResult> DeletePhraseAsync([FromRoute] Guid guid)
        {
            await _phraseService.DeletePhraseAsync(guid);
            return Ok();
        }
    }
}