using MediatR;

namespace PayrollService.Application.Features.Payrolls.Commands;

public class CreatePayrollCommand : IRequest<Guid>
{
    public string EmployeeName { get; set; } = default!;
    public decimal Salary { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
}
