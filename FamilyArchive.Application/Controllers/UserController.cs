namespace FamilyArchive.Application.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Dto.Account;
    using Infrustructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(IUserManager userManager, ITokenService tokenService, IMapper mapper)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync([FromBody]CreateAccountDto createAccountDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userManager.CreateAsync(_mapper.Map<User>(createAccountDto), createAccountDto.Password);
            if (!result.Succeeded)
            {
                result.Errors.ToList().ForEach(x => ModelState.AddModelError(x.Code, x.Description));
                return BadRequest(ModelState);
            }

            return Ok(_tokenService.GetToken());
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody]LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = await _userManager.LoginAsync(loginDto.Username, loginDto.Password);
            if (user == null)
                return NotFound();
            return Ok(_tokenService.GetToken());
        }

        [HttpGet]
        [Route("test")]
        [Authorize]
        public IActionResult Test()
        {
            return Ok(_tokenService.GetToken());
        }
    }
}
