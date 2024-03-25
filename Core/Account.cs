using System.ComponentModel.DataAnnotations;

namespace Core;

public class Account
{
    [Key] public int Id { get; set; }

    [Required] [MinLength(3)] public string Name { get; set; }

    [Required] public int BankCode { get; set; }

    [Required] public string BankName { get; set; }

    [Required] [MinLength(11)] public string PixKey { get; set; }
}