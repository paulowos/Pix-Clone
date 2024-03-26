using System.ComponentModel.DataAnnotations;

namespace Core;

public class Bank
{
    [Key] [Required] public int Id { get; init; }

    [Required] [MinLength(3)] public string Name { get; init; } = null!;
}