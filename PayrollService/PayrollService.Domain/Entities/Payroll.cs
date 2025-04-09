namespace PayrollService.Domain.Entities;

public class Payroll
{
    public Guid Id { get; set; }
    public string EmployeeName { get; set; } = default!;
    public decimal Salary { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
}
