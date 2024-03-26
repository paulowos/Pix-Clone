using AccountApi.Models.Dto;
using Core;

namespace AccountApi.Models.Interfaces;

public interface IBankRepository
{
    public Bank? GetById(int id);
    public void Add(BankDto bank);
}