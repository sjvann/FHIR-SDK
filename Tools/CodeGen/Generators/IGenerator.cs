using CodeGen.Models;

namespace CodeGen.Generators;

public interface IGenerator
{
    string BuildResourceRegistry(string ns, string version, IEnumerable<string> resourceTypes);

    string BuildPatient(string ns, IReadOnlyDictionary<string, Cardinality> cards);
    string BuildObservation(string ns, IReadOnlyDictionary<string, Cardinality> cards);
    string BuildOrganization(string ns, IReadOnlyDictionary<string, Cardinality> cards);
}
