namespace Domain.Entities.Sanaei;

public record WsSettings(bool acceptProxyProtocol, string Path, Dictionary<string, string> Headers);