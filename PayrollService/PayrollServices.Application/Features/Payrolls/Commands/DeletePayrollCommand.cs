using MediatR;

namespace PayrollService.Application.Features.Payrolls.Commands;

public class DeletePayrollCommand : IRequest
{
    public Guid Id { get; set; }
}
