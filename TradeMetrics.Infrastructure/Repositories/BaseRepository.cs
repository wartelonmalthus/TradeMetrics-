using Microsoft.EntityFrameworkCore;
using TradeMetrics.Domain;
using TradeMetrics.Infrastructure.Context;
using TradeMetrics.Infrastructure.Interfaces;

namespace TradeMetrics.Infrastructure.Repositories;
public class BaseRepository<T> : IBaseRepository<T> where T : Register
{
	private readonly TradeContext _context;
	private readonly DbSet<T> _dbSet;

	public BaseRepository(TradeContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();

	}
	public async Task AddAsync(T entity)
	{
		await _dbSet.AddAsync(entity);
		await _context.SaveChangesAsync();
	}

	public async Task AddListAsync(IEnumerable<T> entities)
	{
		await _dbSet.AddRangeAsync(entities);
		await _context.SaveChangesAsync();
	}
	public async Task<bool> VerifyExist(int id)
	{
		return await _dbSet.AnyAsync(x => x.Id == id);
	}

	public async Task DeleteAsync(int id)
	{
		var entity = await GetByIdAsync(id);

		if (entity != null) 
		 _dbSet.Remove(entity);
	}

	public async Task<(IEnumerable<T> Items, int TotalCount)> GetAllAsync(int page, int pageSize)
	{

		var items = await _dbSet
			.Skip((page - 1) * pageSize)
			.Take(pageSize)
			.ToListAsync();

		var totalCount = await _dbSet.CountAsync();

		return (items, totalCount);
	}

	public async Task<T?> GetByIdAsync(int id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

	public async Task UpdateAsync(T entity)
	{
		_dbSet.Update(entity);
		await _context.SaveChangesAsync();
	}
}