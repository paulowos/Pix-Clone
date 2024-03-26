using System.ComponentModel.DataAnnotations;

namespace AccountApi.Models.Dto;

public class AccountInDto
{
    [Required] [MinLength(3)] public string Name { get; init; } = null!;

    [Required] public int BankId { get; init; }

    [Required] [MinLength(11)] public string PixKey { get; init; } = null!;
}