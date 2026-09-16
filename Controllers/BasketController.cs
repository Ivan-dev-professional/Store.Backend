using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Store.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class BasketController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetBasket()
        => Ok(await mediator.Send(new GetBasketQuery()));

    [HttpPost("items")]
    public async Task<IActionResult> AddItem([FromBody] AddBasketItemRequest request)
        => Ok(await mediator.Send(new AddBasketItemCommand(request)));

    [HttpPut("items")]
    public async Task<IActionResult> UpdateItem([FromBody] UpdateBasketItemRequest request)
        => Ok(await mediator.Send(new UpdateBasketItemCommand(request)));

    [HttpDelete("items/{id:guid}")]
    public async Task<IActionResult> RemoveItem([FromRoute] Guid id)
        => Ok(await mediator.Send(new RemoveBasketItemCommand(id)));

    [HttpDelete("clear")]
    public async Task<IActionResult> ClearBasket()
        => Ok(await mediator.Send(new ClearBasketCommand()));
}