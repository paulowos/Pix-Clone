using AccountApi.Models.Dto;
using AccountApi.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BankController(IBankRepository repository) : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var bank = repository.GetById(id);
        if (bank == null) return NotFound();
        return Ok(bank);
    }

    [HttpPost]
    public IActionResult Add(BankDto bankDto)
    {
        repository.Add(bankDto);
        return Created();
    }
}