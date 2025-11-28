namespace Archiduct.Framework.Capabilities;

using Microsoft.Testing.Extensions.TrxReport.Abstractions;

/// <summary>
/// Capability to indicate that Archiduct supports TRX reporting.
/// </summary>
internal sealed class TrxReportCapability : ITrxReportCapability
{
    /// <inheritsdoc cref="ITrxReportCapability.IsSupported"/>
    public bool IsSupported { get; } = true;

    /// <inheritsdoc cref="ITrxReportCapability.Enable"/>
    public void Enable() { }
}
