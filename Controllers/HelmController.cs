using Microsoft.AspNetCore.Mvc;
using ric_avi_iskfu19.Models;
using ric_avi_iskfu19.Services;

namespace ric_avi_iskfu19.Controller;
[ApiController]
[Route("api/products")]
public class HelmController : ControllerBase
{
    private readonly ILogger<HelmController> _logger;
    private readonly HelmService _helmetService;

    public HelmController(
        ILogger<HelmController> logger, HelmService helmetService)
    {
        _logger = logger;
        _helmetService = helmetService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Helmet>>> GetHelmets()
    {
        var helmets = await _helmetService.GetHelmet();
        return Ok(helmets);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetHelmetId(int id)
    {
        var helmets = await _helmetService.GetHelmetId(id); 
        return Ok(helmets);
    }
    
    [HttpPost]
    public async Task<ActionResult<object>> CreateProduct(Helmetmaker helmetmaker)
    {
        var helmet = await _helmetService.Create(helmetmaker);
        return Ok(helmet);
    }

}