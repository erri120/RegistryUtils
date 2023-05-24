using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NetEscapades.EnumGenerators;

namespace RegistryUtils.Core.Types;

/// <summary>
/// Represents a logical pre-defined group of keys, sub-keys and values in the registry that has a
/// set of supporting files loaded into memory when the operating system is started or a user logs in.
/// </summary>
/// <remarks>
/// This enumeration type mirrors <see cref="Microsoft.Win32.RegistryHive"/>.
/// </remarks>
[PublicAPI]
[SuppressMessage(
    "ReSharper",
    "EnumUnderlyingTypeIsInt",
    Justification = "Prevents the compiler from using a different type.")]
[EnumExtensions]
public enum RegistryHive : int
{
    /// <summary>
    /// Represents the <c>HKEY_CLASSES_ROOT</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.ClassesRoot"/> and has the
    /// 32-bit integer value <c>0x80000000</c> or <c>-2147483648</c>.
    /// </remarks>
    [Description("HKEY_CLASSES_ROOT")]
    ClassesRoot = -2147483648,

    /// <summary>
    /// Represents the <c>HKEY_CURRENT_USER</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.CurrentUser"/> and has the
    /// 32-bit integer value <c>0x80000001</c> or <c>-2147483647</c>.
    /// </remarks>
    [Description("HKEY_CURRENT_USER")]
    CurrentUser = -2147483647,

    /// <summary>
    /// Represents the <c>HKEY_LOCAL_MACHINE</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.LocalMachine"/> and has the
    /// 32-bit integer value <c>0x80000002</c> or <c>-2147483646</c>.
    /// </remarks>
    [Description("HKEY_LOCAL_MACHINE")]
    LocalMachine = -2147483646,

    /// <summary>
    /// Represents the <c>HKEY_USERS</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.Users"/> and has the
    /// 32-bit integer value <c>0x80000003</c> or <c>-2147483645</c>.
    /// </remarks>
    [Description("HKEY_USERS")]
    Users = -2147483645,

    /// <summary>
    /// Represents the <c>HKEY_PERFORMANCE_DATA</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.PerformanceData"/> and has the
    /// 32-bit integer value <c>0x80000004</c> or <c>-2147483644</c>.
    /// </remarks>
    [Description("HKEY_PERFORMANCE_DATA")]
    PerformanceData = -2147483644,

    /// <summary>
    /// Represents the <c>HKEY_CURRENT_CONFIG</c> base key.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryHive.CurrentConfig"/> and has the
    /// 32-bit integer value <c>0x80000005</c> or <c>-2147483643</c>.
    /// </remarks>
    [Description("HKEY_CURRENT_CONFIG")]
    CurrentConfig = -2147483643,
}
