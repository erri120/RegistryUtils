using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NetEscapades.EnumGenerators;
using MSRegistryValueKind = Microsoft.Win32.RegistryValueKind;

namespace RegistryUtils.Core.Types;

/// <summary>
/// Represents the data types to use when storing values in the registry,
/// or identifies the data type of a value in the registry.
/// </summary>
/// <remarks>
/// This enumeration type mirrors <see cref="Microsoft.Win32.RegistryValueKind"/>.
/// </remarks>
[PublicAPI]
[SuppressMessage(
    "ReSharper",
    "EnumUnderlyingTypeIsInt",
    Justification = "Prevents the compiler from using a different type.")]
[EnumExtensions]
public enum RegistryValueKind : int
{
    /// <summary>
    /// No data type.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.None"/> and has the
    /// 32-bit integer value <c>0xFFFFFFFF</c> or <c>-1</c>.
    /// </remarks>
    [SuppressMessage("ReSharper", "CommentTypo")]
    [Description("None")]
    None = -1,

    /// <summary>
    /// An unsupported registry data type.
    /// For example, the Microsoft Windows API registry data type <c>REG_RESOURCE_LIST</c> is unsupported.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.Unknown"/> and has the
    /// 32-bit integer value <c>0</c>.
    /// </remarks>
    [Description("Unknown")]
    Unknown = 0,

    /// <summary>
    /// A null-terminated string.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.String"/> and has the
    /// 32-bit integer value <c>1</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_SZ</c>.
    /// </remarks>
    [Description("REG_SZ")]
    String = 1,

    /// <summary>
    /// A null-terminated string that contains unexpanded references to environment variables,
    /// such as %PATH%, that are expanded when the value is retrieved.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.ExpandString"/> and has the
    /// 32-bit integer value <c>2</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_EXPAND_SZ</c>.
    /// </remarks>
    [Description("REG_EXPAND_SZ")]
    ExpandString = 2,

    /// <summary>
    /// Binary data in any form.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.Binary"/> and has the
    /// 32-bit integer value <c>3</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_BINARY</c>.
    /// </remarks>
    [Description("REG_BINARY")]
    Binary = 3,

    /// <summary>
    /// A 32-bit binary number.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.DWord"/> and has the
    /// 32-bit integer value <c>4</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_DWORD</c>.
    /// </remarks>
    [Description("REG_DWORD")]
    DWord = 4,

    /// <summary>
    /// An array of null-terminated strings, terminated by two null characters.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.MultiString"/> and has the
    /// 32-bit integer value <c>7</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_MULTI_SZ</c>.
    /// </remarks>
    [Description("REG_MULTI_SZ")]
    MultiString = 7,

    /// <summary>
    /// A 64-bit binary number.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryValueKind.QWord"/> and has the
    /// 32-bit integer value <c>11</c>.
    /// This value is equivalent to the Windows API registry data type <c>REG_QWORD</c>.
    /// </remarks>
    [Description("REG_QWORD")]
    QWord = 11,
}
