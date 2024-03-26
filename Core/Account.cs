using System.ComponentModel.DataAnnotations;

namespace Core;

public class Account
{
    [Key] public int Id { get; init; }

    [Required] [MinLength(3)] public string Name { get; init; } = null!;

    [Required] public int BankId { get; init; }

    public Bank Bank { get; init; } = null!;

    [Required] [MinLength(11)] public string PixKey { get; init; } = null!;
}