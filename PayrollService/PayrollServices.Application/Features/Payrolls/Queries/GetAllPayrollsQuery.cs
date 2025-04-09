using MediatR;
using PayrollService.Application.DTOs;

namespace PayrollService.Application.Features.Payrolls.Queries;

public class GetAllPayrollsQuery : IRequest<List<PayrollDto>> { }
