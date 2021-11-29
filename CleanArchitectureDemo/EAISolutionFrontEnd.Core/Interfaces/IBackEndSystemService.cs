using EAISolutionFrontEnd.Core.Entities;
using System.Threading.Tasks;

namespace EAISolutionFrontEnd.Core.Interfaces
{
    public interface IBackEndSystemService
    {
        Task sendRequestToBackEnd(Request request, string directory);
    }
}
