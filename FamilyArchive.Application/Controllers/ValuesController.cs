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
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get() => new string[] { "Hello", "World" };
    }
}