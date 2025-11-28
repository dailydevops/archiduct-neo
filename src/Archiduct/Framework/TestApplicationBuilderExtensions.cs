namespace Archiduct.Framework;

using Archiduct.Framework.Capabilities;
using Microsoft.Testing.Platform.Builder;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using NetEvolve.Arguments;

/// <summary>
/// Provides extension methods for configuring Archiduct test framework support in an <see cref="ITestApplicationBuilder"/> instance.
/// </summary>
/// <remarks>These extension methods enable integration of Archiduct-specific capabilities and providers into the
/// test application builder. Use these methods to register the Archiduct test framework when setting up test
/// environments that require Archiduct features.</remarks>
internal static class TestApplicationBuilderExtensions
{
    public static ITestApplicationBuilder AddArchiduct(this ITestApplicationBuilder builder)
    {
        Argument.ThrowIfNull(builder);

        return builder
            .RegisterTestFramework(
                serviceProvider => new TestFrameworkCapabilities(GetCapabilities(serviceProvider)),
                (capabilities, serviceProvider) => new ArchiductTestFramework(capabilities, serviceProvider)
            )
            .RegisterCommandLineProvider()
            .RegisterTestHostProvider();
    }

    private static IReadOnlyCollection<ITestFrameworkCapability> GetCapabilities(IServiceProvider serviceProvider) =>
        [new BannerCapability(serviceProvider), new TrxReportCapability(), new GracefulStopTestExecutionCapability()];

    private static ITestApplicationBuilder RegisterCommandLineProvider(this ITestApplicationBuilder builder)
    {
        // TODO: Implement command line provider for Archiduct if needed.
        return builder;
    }

    private static ITestApplicationBuilder RegisterTestHostProvider(this ITestApplicationBuilder builder)
    {
        // TODO: Implement test host provider for Archiduct if needed.
        return builder;
    }
}
