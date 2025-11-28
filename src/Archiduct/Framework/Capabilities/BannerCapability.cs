namespace Archiduct.Framework.Capabilities;

using System;
using System.Threading.Tasks;
using Archiduct;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using Microsoft.Testing.Platform.Services;

internal sealed class BannerCapability : IBannerMessageOwnerCapability
{
    private readonly IServiceProvider _serviceProvider;
    private const string Separator = "----------------------------------------";

    public BannerCapability(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public Task<string?> GetBannerMessageAsync()
    {
        var platformInformation = _serviceProvider.GetRequiredService<IPlatformInformation>();

        return Task.FromResult<string?>(
            $"""
            {ArchiductFramework.DisplayName} v{ArchiductFramework.Version} running on {platformInformation.Name} v{platformInformation.Version}
            {Separator}
            """
        );
    }
}
