using LuckyStone.Domain.Models;

namespace LuckyStone.WebApi.Services.Abstraction;

public interface IStoneService
{
    Task<IEnumerable<Stone>> GetAllStonesAsync();
}