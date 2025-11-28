namespace Archiduct.Models;

public sealed partial class ArchiductGlobalContext
{
    private static readonly Lazy<ArchiductGlobalContext> _instance = new Lazy<ArchiductGlobalContext>(
        LazyThreadSafetyMode.ExecutionAndPublication
    );

    public static ArchiductGlobalContext Instance => _instance.Value;

    internal bool IsGracefulStopRequested { get; set; }
}
