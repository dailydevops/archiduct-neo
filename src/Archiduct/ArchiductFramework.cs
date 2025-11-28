namespace Archiduct;

/// <summary>
/// Provides constants that define metadata for the Archiduct integration of <b>Microsoft.Testing.Platform</b>.
/// </summary>
internal static class ArchiductFramework
{
    /// <summary>
    /// Gets the display name of the Archiduct framework.
    /// </summary>
    public const string DisplayName = "Archiduct";

    /// <summary>
    /// Gets the description of the Archiduct framework.
    /// </summary>
    public const string Description =
        "Archiduct is a lightweight architecture testing framework for .NET built directly on Microsoft.Testing.Platform.";

    /// <summary>
    /// Gets the unique identifier (UID) of the Archiduct framework.
    /// </summary>
    public const string Uid = "Archiduct.Framework";

    /// <summary>
    /// Gets the version number of the ArchiductFramework assembly as a string.
    /// </summary>
    public static string Version { get; } =
        typeof(ArchiductFramework).Assembly.GetName().Version?.ToString(3) ?? "1.0.0";
}
