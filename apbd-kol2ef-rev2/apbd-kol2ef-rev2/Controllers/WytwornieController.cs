using apbd_kol2ef_rev2.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_kol2ef_rev2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WytwornieController : ControllerBase
{
    private readonly IMusicLabelsService _musicLabelsService;

    public WytwornieController(IMusicLabelsService musicLabelsService)
    {
        _musicLabelsService = musicLabelsService;
    }

    [HttpGet("muzycy/{id:int}")]
    public async Task<IActionResult> GetMuzyk(int id)
    {
        return Ok(await _musicLabelsService.GetMuzykByIdAsync(id));
    }
}