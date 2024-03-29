using System.ComponentModel.DataAnnotations;

namespace AccountApi.Models.Dto;

public class BankDto
{
    [Required] [MinLength(3)] public string Name { get; init; } = null!;
}