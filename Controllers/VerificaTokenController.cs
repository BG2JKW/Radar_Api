using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;
using Radar_Api.Models;

namespace Radar_Api.Controllers;

[Route("authToken")]
[ApiController]
public class VerificaTokenController : ControllerBase
{
    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        return StatusCode(200, "logado");
    }
}