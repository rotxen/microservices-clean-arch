using Microsoft.EntityFrameworkCore;
using PayrollService.Domain.Entities;
using PayrollService.Domain.Interfaces;
using PayrollService.Infrastructure.Persistence;

namespace PayrollService.Infrastructure.Repositories;

public class PayrollRepository : IPayrollRepository
{
	private readonly PayrollDbContext _context;

	public PayrollRepository(PayrollDbContext context)
	{
		_context = context;
	}

	public async Task<IEnumerable<Payroll>> GetAllAsync() => await _context.Payrolls.ToListAsync();

	public async Task<Payroll?> GetByIdAsync(Guid id) => await _context.Payrolls.FindAsync(id);

	public async Task AddAsync(Payroll payroll)
	{
		_context.Payrolls.Add(payroll);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(Payroll payroll)
	{
		_context.Payrolls.Update(payroll);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(Guid id)
	{
		var entity = await _context.Payrolls.FindAsync(id);
		if (entity != null)
		{
			_context.Payrolls.Remove(entity);
			await _context.SaveChangesAsync();
		}
	}
}
