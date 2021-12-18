using System;
using System.Collections.Generic;
using System.Text;
using TDRSolutionFrontEnd.Core.Entities;

namespace TDRSolutionFrontEnd.Core.Specifications
{
    public class DeclarationsByUser : BaseSpecification<DeclarationRevenus>
    {
        public DeclarationsByUser(int userId) : base(x => x.Usager.Id == userId)
        {
        }
    }

}
