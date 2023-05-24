using System.Runtime.Versioning;
using JetBrains.Annotations;

namespace RegistryUtils.Core.Windows;

/// <summary>
/// Implementation of <see cref="IRegistry"/> that uses the real Windows Registry.
/// </summary>
/// <remarks>
/// This implementation is only supported on Windows and uses <c>Microsoft.Win32.Registry</c>.
/// </remarks>
/// <seealso cref="InMemory.InMemoryRegistry"/>
[PublicAPI]
[SupportedOSPlatform("windows")]
public class WindowsRegistry : IRegistry
{
}
