using Application.DTOs.Funcionario;
using Application.Features.Funcionario.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Organization.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    private readonly IMediator _mediator;

    public FuncionarioController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // POST api/<FuncionarioController>
    [HttpPost]
    public async Task<ActionResult<Guid>> Post([FromBody] CreateFuncionarioDto Funcionario)
    {
        var command = new CreateNewFuncionarioCommand { NewFuncionario = Funcionario };
        var repsonse = await _mediator.Send(command);
        return Ok(repsonse);
    }

}

