using EAISolutionFrontEnd.Core.Entities;


namespace EAISolutionFrontEnd.Core.Specifications
{
    public class RequestByUser : BaseSpecification<Request>
    {
        public RequestByUser(int userId) : base(x => x.User.Id == userId)
        {
        }
    }

}
