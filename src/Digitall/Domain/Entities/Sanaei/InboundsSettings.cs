using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Sanaei;

[ComplexType]
public record InboundsSettings(List<Client> Clients, string Decryption, List<Fallback>? Fallbacks);