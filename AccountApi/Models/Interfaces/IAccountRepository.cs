using AccountApi.Models.Dto;

namespace AccountApi.Models.Interfaces;

public interface IAccountRepository
{
    public AccountOutDto? GetByPixKey(string pixKey);
    public AccountOutDto Add(AccountInDto accountDto);
}