using MediatR;

namespace OrderService.Application.Features.Orders.Commands;

public class DeleteOrderCommand : IRequest
{
    public Guid Id { get; set; }
}