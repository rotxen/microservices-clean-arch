using PayrollService.Domain.Entities;

namespace PayrollService.Domain.Interfaces;

public interface IPayrollRepository
{
    Task<IEnumerable<Payroll>> GetAllAsync();
    Task<Payroll?> GetByIdAsync(Guid id);
    Task AddAsync(Payroll payroll);
    Task UpdateAsync(Payroll payroll);
    Task DeleteAsync(Guid id);
}
