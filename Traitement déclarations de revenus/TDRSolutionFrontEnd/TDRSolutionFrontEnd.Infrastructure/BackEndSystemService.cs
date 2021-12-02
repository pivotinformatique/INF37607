using System.Xml.Serialization;

using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class BackEndSystemService : IBackEndSystemService
    {
        public async Task sendDemandeTraitementToBackEnd(DeclarationRevenus declarationRevenus, string directory)
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("ns0", "http://TDRSolution.DeclarationRevenus");

            string xml = XmlTranfromHelper.Serialize(declarationRevenus, namespaces);

            await File.WriteAllTextAsync(directory + "Request" + DateTime.Now.Ticks + ".xml", xml);

        }
    }
}
