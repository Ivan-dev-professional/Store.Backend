using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Store.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class OrdersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderRequest request)
        => Ok(await mediator.Send(new CreateOrderCommand(request)));

    [HttpGet("my-orders")]
    public async Task<IActionResult> GetUserOrders()
        => Ok(await mediator.Send(new GetUserOrdersQuery()));

    [HttpPost("{id:guid}/cancel")]
    public async Task<IActionResult> Cancel([FromRoute] Guid id)
        => Ok(await mediator.Send(new CancelOrderCommand(id)));

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        => Ok(await mediator.Send(new GetAllOrdersQuery(page, pageSize)));

    [HttpGet("{id:guid}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
        => Ok(await mediator.Send(new GetOrderByIdQuery(id)));

    [HttpPut("{id:guid}/status")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateStatus([FromRoute] Guid id, [FromBody] UpdateOrderStatusRequest request)
        => Ok(await mediator.Send(new UpdateOrderStatusCommand(id, request)));
}