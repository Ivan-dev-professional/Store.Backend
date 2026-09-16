using MediatR;

namespace Store.Backend.Controllers;

// --- Basket DTOs & Commands ---
public record GetBasketQuery() : IRequest<object>;
public record AddBasketItemRequest(Guid ProductId, int Quantity);
public record AddBasketItemCommand(AddBasketItemRequest Request) : IRequest<object>;
public record UpdateBasketItemRequest(Guid ProductId, int Quantity);
public record UpdateBasketItemCommand(UpdateBasketItemRequest Request) : IRequest<object>;
public record RemoveBasketItemCommand(Guid Id) : IRequest<object>;
public record ClearBasketCommand() : IRequest<object>;

// --- Products DTOs & Commands ---
public record GetProductsQuery(int Page, int PageSize) : IRequest<object>;
public record GetProductByIdQuery(Guid Id) : IRequest<object>;
public record SearchProductsQuery(string Query, int Page, int PageSize) : IRequest<object>;
public record CreateProductRequest(string Name, decimal Price);
public record CreateProductCommand(CreateProductRequest Request) : IRequest<object>;
public record UpdateProductRequest(string Name, decimal Price);
public record UpdateProductCommand(Guid Id, UpdateProductRequest Request) : IRequest<object>;
public record DeleteProductCommand(Guid Id) : IRequest<object>;

// --- Orders DTOs & Commands ---
public record CreateOrderRequest(Guid BasketId, string Address);
public record CreateOrderCommand(CreateOrderRequest Request) : IRequest<object>;
public record GetUserOrdersQuery() : IRequest<object>;
public record GetOrderByIdQuery(Guid Id) : IRequest<object>;
public record CancelOrderCommand(Guid Id) : IRequest<object>;
public record UpdateOrderStatusRequest(string Status);
public record UpdateOrderStatusCommand(Guid Id, UpdateOrderStatusRequest Request) : IRequest<object>;
public record GetAllOrdersQuery(int Page = 1, int PageSize = 10) : IRequest<object>;