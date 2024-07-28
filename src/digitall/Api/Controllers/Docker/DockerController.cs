using Api.Controllers.Base;
using Application.Services.Interface.Docker;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Docker;

[ApiVersion(1)]
public class DockerController(IDockerService dockerService):BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetDocker()
    {
        return Ok(await dockerService.GetContainerInformations());
    }
}