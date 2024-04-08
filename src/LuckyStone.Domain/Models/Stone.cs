namespace LuckyStone.Domain.Models;

public class Stone
{
    public int Id { get; init; }
    public StoneType Type { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public decimal Price { get; init; }
}