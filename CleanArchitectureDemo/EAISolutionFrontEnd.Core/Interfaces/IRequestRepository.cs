using System.Threading.Tasks;
using EAISolutionFrontEnd.SharedKernel.Interfaces;
using EAISolutionFrontEnd.Core.Entities;

namespace EAISolutionFrontEnd.Core.Interfaces
{
    public interface IRequestRepository : IAsyncRepository<Request>
    {
        Task<Request> GetByIdWithRequestItemsAsync(int id);
    }
}
