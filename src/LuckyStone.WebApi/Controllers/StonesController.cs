using LuckyStone.WebApi.Services.Abstraction;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LuckyStone.WebApi.Controllers;

[Route("/stones")]
public class StonesController : Controller
{
    private readonly IStoneService _stoneService;

    public StonesController(IStoneService stoneService)
    {
        _stoneService = stoneService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStones()
    {
        return Ok(_stoneService.GetAllStones());
    }
}