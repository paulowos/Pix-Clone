using AccountApi.Context;
using AccountApi.Models.Dto;
using AccountApi.Models.Interfaces;
using Core;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Repositories;

public class AccountRepository(AccountContext context) : IAccountRepository
{
    public AccountOutDto? GetByPixKey(string pixKey)
    {
        var account = context.Accounts
            .Include(a => a.Bank)
            .FirstOrDefault(a => a.PixKey == pixKey);

        if (account == null) return null;

        var accountOutDto = new AccountOutDto
        {
            Name = account.Name,
            BankName = account.Bank.Name,
            PixKey = account.PixKey
        };

        return accountOutDto;
    }

    public void Add(AccountInDto accountDto)
    {
        context.Accounts.Add(new Account
        {
            Name = accountDto.Name,
            BankId = accountDto.BankId,
            PixKey = accountDto.PixKey
        });
        context.SaveChanges();
    }
}