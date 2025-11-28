namespace Archiduct.Framework;

using System;
using System.Threading.Tasks;
using Archiduct.Logging;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using Microsoft.Testing.Platform.Logging;
using Microsoft.Testing.Platform.Services;

internal sealed class ArchiductTestFramework : ITestFramework
{
    private readonly ITestFrameworkCapabilities _capabilities;
    private readonly ILogger _logger;
    private readonly IServiceProvider _serviceProvider;

    public string Uid => ArchiductFramework.Uid;

    public string Version => ArchiductFramework.Version;

    public string DisplayName => ArchiductFramework.DisplayName;

    public string Description => ArchiductFramework.Description;

    public ArchiductTestFramework(ITestFrameworkCapabilities capabilities, IServiceProvider serviceProvider)
    {
        _capabilities = capabilities;
        _serviceProvider = serviceProvider;

        var loggingFactory = _serviceProvider.GetService<ILoggerFactory>();
        _logger = loggingFactory?.CreateLogger<ArchiductTestFramework>() ?? NullLogger<ArchiductTestFramework>.Instance;
    }

    public Task<CloseTestSessionResult> CloseTestSessionAsync(CloseTestSessionContext context) =>
        Task.FromResult(new CloseTestSessionResult { IsSuccess = false });

    public Task<CreateTestSessionResult> CreateTestSessionAsync(CreateTestSessionContext context) =>
        Task.FromResult(new CreateTestSessionResult { IsSuccess = true });

    public Task ExecuteRequestAsync(ExecuteRequestContext context) => Task.CompletedTask;

    public Task<bool> IsEnabledAsync() => Task.FromResult(true);
}
