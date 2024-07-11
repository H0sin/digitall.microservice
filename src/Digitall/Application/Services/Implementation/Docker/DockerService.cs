using Application.Services.Interface.Docker;
using Docker.DotNet;
using Docker.DotNet.Models;

namespace Application.Services.Implementation.Docker;

public class DockerService : IDockerService
{
    public async Task<IList<ContainerListResponse>> GetContainerInformations()
    {
        DockerClient? dockerClient =
            new DockerClientConfiguration().CreateClient(); //npipe://./pipe/docker_engine

        //unix:///var/run/docker.sock
        IList<ContainerListResponse> containers = await dockerClient.Containers.ListContainersAsync(new ContainersListParameters
        {
            All = true
        });
        
        return containers;
    }
}