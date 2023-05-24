using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using RegistryUtils.Core.Types;
using MSRegistryHive = Microsoft.Win32.RegistryHive;
using MSRegistryValueKind = Microsoft.Win32.RegistryValueKind;
using MSRegistryView = Microsoft.Win32.RegistryView;

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
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryHive)} can be used on all platforms.")]
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
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryValueKind)} can be used on all platforms.")]
    public static MSRegistryValueKind Convert(RegistryValueKind valueKind)
    {
        var value = (int)valueKind;
        return (MSRegistryValueKind)value;
    }

    /// <summary>
    /// Converts a <see cref="RegistryView"/> from this library to a
    /// <see cref="Microsoft.Win32.RegistryView"/> from <c>Microsoft.Win32.Registry</c>.
    /// </summary>
    /// <param name="view"></param>
    /// <returns></returns>
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryView)} can be used on all platforms.")]
    public static MSRegistryView Convert(RegistryView view)
    {
        var value = (int)view;
        return (MSRegistryView)value;
    }
}
