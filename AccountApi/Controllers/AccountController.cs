using AccountApi.Models.Dto;
using AccountApi.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers;

[ApiController]
[Route("pix")]
public class AccountController(IAccountRepository repository) : ControllerBase
{
    [HttpGet("{pixKey}")]
    public IActionResult GetByPixKey(string pixKey)
    {
        var account = repository.GetByPixKey(pixKey);
        if (account == null) return NotFound();
        return Ok(account);
    }

    [HttpPost]
    public IActionResult Add(AccountInDto accountDto)
    {
        repository.Add(accountDto);
        return Created();
    }
}