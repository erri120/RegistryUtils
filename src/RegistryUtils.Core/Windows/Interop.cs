using JetBrains.Annotations;
using RegistryUtils.Core.Types;

namespace RegistryUtils.Core.Windows;
using MSRegistryHive = Microsoft.Win32.RegistryHive;

/// <summary>
/// Helper methods for converting values used in this library, to values used in <c>Microsoft.Win32.Registry</c>.
/// </summary>
[PublicAPI]
public static class Interop
{
    /// <summary>
    /// Converts a <see cref="RegistryHive"/> from this library to a
    /// <see cref="Microsoft.Win32.RegistryHive"/> from <c>Microsoft.Win32.Registry</c>.
    /// </summary>
    /// <param name="hive">Value to convert.</param>
    /// <returns></returns>
    public static MSRegistryHive Convert(RegistryHive hive)
    {
        var value = (int)hive;
        return (MSRegistryHive)value;
    }
}
