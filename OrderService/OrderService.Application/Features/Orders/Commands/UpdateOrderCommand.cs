using MediatR;

namespace OrderService.Application.Features.Orders.Commands;

public class UpdateOrderCommand : IRequest
{
	public Guid Id { get; set; }
	public string Title { get; set; } = default!;
	public string Description { get; set; } = default!;
	public decimal Amount { get; set; }
}