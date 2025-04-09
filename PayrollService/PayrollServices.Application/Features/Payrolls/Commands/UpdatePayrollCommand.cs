using MediatR;

namespace PayrollService.Application.Features.Payrolls.Commands;

public class UpdatePayrollCommand : IRequest
{
    public Guid Id { get; set; }
    public string EmployeeName { get; set; } = default!;
    public decimal Salary { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
}
