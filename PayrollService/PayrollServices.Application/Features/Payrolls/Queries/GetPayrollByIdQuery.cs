using MediatR;
using PayrollService.Application.DTOs;

namespace PayrollService.Application.Features.Payrolls.Queries;

public class GetPayrollByIdQuery : IRequest<PayrollDto>
{
    public Guid Id { get; set; }
}
