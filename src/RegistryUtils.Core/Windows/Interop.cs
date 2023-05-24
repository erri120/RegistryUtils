using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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
        if (!RegistryHiveExtensions.IsDefined(hive))
            throw new ArgumentOutOfRangeException(nameof(hive), hive, $"The provided {nameof(RegistryHive)} value is not valid!");
        return ConvertCore(hive);
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
        if (!RegistryValueKindExtensions.IsDefined(valueKind))
            throw new ArgumentOutOfRangeException(nameof(valueKind), valueKind, $"The provided {nameof(RegistryHive)} value is not valid!");
        return ConvertCore(valueKind);
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
        if (!RegistryViewExtensions.IsDefined(view))
            throw new ArgumentOutOfRangeException(nameof(view), view, $"The provided {nameof(RegistryHive)} value is not valid!");
        return ConvertCore(view);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static MSRegistryHive ConvertCore(RegistryHive hive)
    {
        var value = (int)hive;
        return (MSRegistryHive)value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static MSRegistryValueKind ConvertCore(RegistryValueKind hive)
    {
        var value = (int)hive;
        return (MSRegistryValueKind)value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static MSRegistryView ConvertCore(RegistryView view)
    {
        var value = (int)view;
        return (MSRegistryView)value;
    }
}
