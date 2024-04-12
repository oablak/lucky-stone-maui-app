using LuckyStone.Domain.Models;
using LuckyStone.WebApi.Services.Abstraction;

namespace LuckyStone.WebApi.Services;

public class StoneService : IStoneService
{
    public async Task<IEnumerable<Stone>> GetAllStonesAsync()
    {
        return new List<Stone>()
        {
            new()
            {
                Description = "These amazonite rose cut cabochons are the most incredible shade of aqua blue with a very subtle soft mottling of lighter material. They are really are stunning and will be a beautiful addition to your jewellery designs.",
                Name = "Amazonite Rose Cut Cabochons",
                Price = 3.25m
            },
            new()
            {
                Description = "These beautiful hand-carved amazonite leaf beads are stunning. They are a gorgeous sea foam blue/green colour and each leaf has been perfectly carved. These would look lovely teamed up with some of our other nature-inspired charms to create beautiful pieces of jewellery. These gemstone beads could be used on their own as a simple charm necklace or attached to our earwire settings with some of our other faceted gemstone beads and briolettes for another nature-inspired design.",
                Name = "Amazonite Carved Leaf Beads - Approx From 12mm",
                Price = 3.25m
            }
        };
    }
}