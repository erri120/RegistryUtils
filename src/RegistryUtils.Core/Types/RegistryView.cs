using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NetEscapades.EnumGenerators;

namespace RegistryUtils.Core.Types;

/// <summary>
/// Specifies which registry view to target on a 64-bit operating system.
/// </summary>
/// <remarks>
/// This enumeration type mirrors <see cref="Microsoft.Win32.RegistryView"/>.
/// </remarks>
[PublicAPI]
[SuppressMessage(
    "ReSharper",
    "EnumUnderlyingTypeIsInt",
    Justification = "Prevents the compiler from using a different type.")]
[EnumExtensions]
public enum RegistryView : int
{
    /// <summary>
    /// The default view.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryView.Default"/> and has the
    /// 32-bit integer value <c>0</c>.
    /// </remarks>
    Default = 0,

    /// <summary>
    /// The 64-bit view.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryView.Registry64"/> and has the
    /// 32-bit integer value <c>0x00000100</c> or <c>256</c>.
    /// </remarks>
    Registry64 = 0x00000100,

    /// <summary>
    /// The 32-bit view.
    /// </summary>
    /// <remarks>
    /// This value mirrors <see cref="Microsoft.Win32.RegistryView.Registry32"/> and has the
    /// 32-bit integer value <c>0x00000200</c> or <c>512</c>.
    /// </remarks>
    Registry32 = 0x00000200,
}
