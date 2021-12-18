using System.Xml.Serialization;

using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;

namespace TDRSolutionFrontEnd.Infrastructure
{
    public class BackEndSystemService : IBackEndSystemService
    {
        public async Task sendDemandeTraitementToBackEnd(DemandeTraitement demandeTraitement, string directory)
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("ns0", "http://TDRSchemas.Schemas.DemandeTraitement");

            string xml = XmlTranfromHelper.Serialize(demandeTraitement, namespaces);

            await File.WriteAllTextAsync(directory + "Declaration" + DateTime.Now.Ticks + ".xml", xml);

        }
    }
}
