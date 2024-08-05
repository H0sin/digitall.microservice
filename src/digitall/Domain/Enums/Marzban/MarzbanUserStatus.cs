namespace Domain.Enums.Marzban;

[Flags]
public enum MarzbanUserStatus : byte
{
    active,
    disabled,
    limited,
    expired,
    on_hold 
}