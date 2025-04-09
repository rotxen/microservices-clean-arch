using MediatR;
using OrderService.Application.DTOs;

namespace OrderService.Application.Features.Orders.Queries;

public class GetAllOrdersQuery : IRequest<List<OrderDto>> { }