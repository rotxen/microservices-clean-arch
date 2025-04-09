namespace OrderService.Application.DTOs;

public class OrderDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; }
}