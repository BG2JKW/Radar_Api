using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Radar_Api.ModelViews;

namespace Radar_Api.Controllers;

[Route("authToken")]
[ApiController]
public class VerificaTokenController : ControllerBase
{
    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var msg = new mensagemVerificaToken();
        msg.Mensagem = "AUTORIZADO";
        return StatusCode(200, msg);
    }
}