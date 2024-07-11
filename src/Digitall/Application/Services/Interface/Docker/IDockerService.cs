using Docker.DotNet.Models;

namespace Application.Services.Interface.Docker;

public interface IDockerService
{
    Task<IList<ContainerListResponse>> GetContainerInformations();
}