namespace Domain.DTOs.Authorization;

public record RoleMenusDto(
    bool Has,
    string Title,
    long Id
);