using JetBrains.Annotations;
using RegistryUtils.Core.Types;
using MSRegistryHive = Microsoft.Win32.RegistryHive;
using MSRegistryValueKind = Microsoft.Win32.RegistryValueKind;

namespace RegistryUtils.Core.Windows;

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

    /// <summary>
    /// Converts a <see cref="RegistryValueKind"/> from this library to a
    /// <see cref="Microsoft.Win32.RegistryValueKind"/> from <c>Microsoft.Win32.Registry</c>.
    /// </summary>
    /// <param name="valueKind"></param>
    /// <returns></returns>
    public static MSRegistryValueKind Convert(RegistryValueKind valueKind)
    {
        var value = (int)valueKind;
        return (MSRegistryValueKind)value;
    }
}
