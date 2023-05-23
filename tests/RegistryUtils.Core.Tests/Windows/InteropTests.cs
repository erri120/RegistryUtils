using System.Diagnostics.CodeAnalysis;
using RegistryUtils.Core.Types;
using RegistryUtils.Core.Windows;
using MSRegistryHive = Microsoft.Win32.RegistryHive;

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
}
