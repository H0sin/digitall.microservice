using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Sanaei;

[ComplexType]
public record InboundsStreamSettings(string Network, string Security, WsSettings? WsSettings);