namespace Archiduct.Framework.Capabilities;

using System.Threading;
using System.Threading.Tasks;
using Archiduct.Models;
using Microsoft.Testing.Platform.Capabilities.TestFramework;

internal sealed class GracefulStopTestExecutionCapability : IGracefulStopTestExecutionCapability
{
    public Task StopTestExecutionAsync(CancellationToken cancellationToken)
    {
        ArchiductGlobalContext.Instance.IsGracefulStopRequested = true;
        return Task.CompletedTask;
    }
}
