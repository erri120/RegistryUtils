using System.Diagnostics.CodeAnalysis;
using RegistryUtils.Core.Types;
using RegistryUtils.Core.Windows;
using MSRegistryHive = Microsoft.Win32.RegistryHive;
using MSRegistryValueKind = Microsoft.Win32.RegistryValueKind;
using MSRegistryView = Microsoft.Win32.RegistryView;

namespace RegistryUtils.Core.Tests.Windows;

public class InteropTests
{
    [Theory]
    [MemberData(nameof(TestValues_ConvertRegistryHive))]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryHive)} can be used on all platforms.")]
    public void Test_ConvertRegistryHive(RegistryHive input, MSRegistryHive expectedOutput)
    {
        var actualOutput = Interop.Convert(input);
        actualOutput.Should().Be(expectedOutput);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryHive)} can be used on all platforms.")]
    public static IEnumerable<object[]> TestValues_ConvertRegistryHive => new[]
    {
        new object[] { RegistryHive.ClassesRoot, MSRegistryHive.ClassesRoot },
        new object[] { RegistryHive.CurrentUser, MSRegistryHive.CurrentUser },
        new object[] { RegistryHive.LocalMachine, MSRegistryHive.LocalMachine },
        new object[] { RegistryHive.Users, MSRegistryHive.Users },
        new object[] { RegistryHive.PerformanceData, MSRegistryHive.PerformanceData },
        new object[] { RegistryHive.CurrentConfig, MSRegistryHive.CurrentConfig },
    };

    [Theory]
    [MemberData(nameof(TestValues_ConvertRegistryValueKind))]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryValueKind)} can be used on all platforms.")]
    public void Test_ConvertRegistryValueKind(RegistryValueKind input, MSRegistryValueKind expectedOutput)
    {
        var actualOutput = Interop.Convert(input);
        actualOutput.Should().Be(expectedOutput);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryValueKind)} can be used on all platforms.")]
    public static IEnumerable<object[]> TestValues_ConvertRegistryValueKind => new[]
    {
        new object[] { RegistryValueKind.None, MSRegistryValueKind.None },
        new object[] { RegistryValueKind.Unknown, MSRegistryValueKind.Unknown },
        new object[] { RegistryValueKind.String, MSRegistryValueKind.String },
        new object[] { RegistryValueKind.ExpandString, MSRegistryValueKind.ExpandString },
        new object[] { RegistryValueKind.Binary, MSRegistryValueKind.Binary },
        new object[] { RegistryValueKind.DWord, MSRegistryValueKind.DWord },
        new object[] { RegistryValueKind.MultiString, MSRegistryValueKind.MultiString },
        new object[] { RegistryValueKind.QWord, MSRegistryValueKind.QWord },
    };

    [Theory]
    [MemberData(nameof(TestValues_ConvertRegistryView))]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryView)} can be used on all platforms.")]
    public void Test_ConvertRegistryView(RegistryView input, MSRegistryView expectedOutput)
    {
        var actualOutput = Interop.Convert(input);
        actualOutput.Should().Be(expectedOutput);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryView)} can be used on all platforms.")]
    public static IEnumerable<object[]> TestValues_ConvertRegistryView => new[]
    {
        new object[] { RegistryView.Default, MSRegistryView.Default },
        new object[] { RegistryView.Registry64, MSRegistryView.Registry64 },
        new object[] { RegistryView.Registry32, MSRegistryView.Registry32 },
    };
}
