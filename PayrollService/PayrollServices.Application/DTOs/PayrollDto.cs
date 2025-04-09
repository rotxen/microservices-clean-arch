namespace PayrollService.Application.DTOs;

public class PayrollDto
{
    public Guid Id { get; set; }
    public string EmployeeName { get; set; } = default!;
    public decimal Salary { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
}
