using System.ComponentModel.DataAnnotations;

namespace AccountApi.Models.Dto;

public class AccountOutDto
{
    [Required] [MinLength(3)] public string Name { get; init; } = null!;

    [Required] public string BankName { get; init; } = null!;

    [Required] [MinLength(11)] public string PixKey { get; init; } = null!;
}