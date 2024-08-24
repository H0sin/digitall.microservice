namespace Domain.Enums.Transaction;

[Flags]
public enum TransactionStatus : byte
{
    Accepted = 1,
    NotAccepted = 2,
    Waiting = 3
}   