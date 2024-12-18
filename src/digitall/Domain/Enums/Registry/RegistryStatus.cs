using Microsoft.AspNetCore.Mvc;

namespace Domain.Enums.Registry;

[Flags]
public enum RegistryStatus : byte
{
    AwaitingSupportReview,
    AwaitingForAcceptModel,
}