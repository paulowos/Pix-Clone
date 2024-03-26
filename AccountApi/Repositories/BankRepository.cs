using AccountApi.Context;
using AccountApi.Models.Dto;
using AccountApi.Models.Interfaces;
using Core;

namespace AccountApi.Repositories;

public class BankRepository(AccountContext context) : IBankRepository
{
    public Bank? GetById(int id)
    {
        return context.Banks.Find(id);
    }

    public void Add(BankDto bank)
    {
        context.Banks.Add(new Bank
        {
            Name = bank.Name
        });
        context.SaveChanges();
    }
}