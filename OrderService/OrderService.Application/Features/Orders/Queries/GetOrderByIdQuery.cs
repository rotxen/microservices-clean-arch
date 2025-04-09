using MediatR;
using OrderService.Application.DTOs;

namespace OrderService.Application.Features.Orders.Queries;

public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public Guid Id { get; set; }
}