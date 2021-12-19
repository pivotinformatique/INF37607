using Microsoft.EntityFrameworkCore;

using TDRSolutionFrontEnd.SharedKernel.Interfaces;
using TDRSolutionFrontEnd.SharedKernel;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly TDRSolutionFrontEndContext _TDRSolutionFrontEndContext;

        public EfRepository(TDRSolutionFrontEndContext tDRSolutionFrontEndContext)
        {
            _TDRSolutionFrontEndContext = tDRSolutionFrontEndContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _TDRSolutionFrontEndContext.Set<T>().AddAsync(entity);
            await _TDRSolutionFrontEndContext.SaveChangesAsync();
            return entity;

        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _TDRSolutionFrontEndContext.Set<T>().Remove(entity);
            await _TDRSolutionFrontEndContext.SaveChangesAsync();
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await _TDRSolutionFrontEndContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _TDRSolutionFrontEndContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _TDRSolutionFrontEndContext.Entry(entity).State = EntityState.Modified;
            await _TDRSolutionFrontEndContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_TDRSolutionFrontEndContext.Set<T>().AsQueryable(), spec);
        }

    }
}

