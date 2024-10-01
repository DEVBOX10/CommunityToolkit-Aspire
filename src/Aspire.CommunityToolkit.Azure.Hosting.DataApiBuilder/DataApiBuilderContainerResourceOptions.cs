﻿namespace Aspire.CommunityToolkit.Azure.Hosting.DataApiBuilder;

/// <summary>
/// This represents the options entity for configuring an API generated by Data Api Builder running in a container.
/// </summary>
public class DataApiBuilderContainerResourceOptions
{
    /// <summary>
    /// Gets or sets the container registry. Default is <c>mcr.microsoft.com</c>.
    /// </summary>
    public string? ContainerRegistry { get; set; } = "mcr.microsoft.com";

    /// <summary>
    /// Gets or sets the container image name. Dafault is <c>azure-databases/data-api-builder</c>.
    /// </summary>
    public string? ContainerImageName { get; set; } = "azure-databases/data-api-builder";

    /// <summary>
    /// Gets or sets the container image tag. Default is <c>latest</c>.
    /// </summary>
    public string ContainerImageTag { get; set; } = "latest";

    /// <summary>
    /// Gets or sets the port number. Default is <c>5000</c>.
    /// </summary>
    public int Port { get; set; } = 5000;

    /// <summary>
    /// Gets or sets the target port number. Default is <c>5000</c>.
    /// </summary>
    public int TargetPort { get; set; } = 5000;


    /// <summary>
    /// Gets or sets the path to the Data Api Builder config path. Default is <c>./dab-config.json</c>.
    /// </summary>
    public string ConfigFilePath { get; set; } = "./dab-config.json";

}