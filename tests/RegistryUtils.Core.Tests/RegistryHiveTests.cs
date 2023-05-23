using System.Diagnostics.CodeAnalysis;
using RegistryUtils.Core.Types;
using MSRegistryHive = Microsoft.Win32.RegistryHive;

namespace RegistryUtils.Core.Tests;

public class RegistryHiveTests
{
    [Theory]
    [MemberData(nameof(TestValues_EnumMemberToValue))]
    public void Test_EnumMemberToValue(RegistryHive member, int expectedValue)
    {
        var actualValue = (int)member;
        actualValue.Should().Be(expectedValue);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static IEnumerable<object[]> TestValues_EnumMemberToValue => new[]
    {
        new object[] { RegistryHive.ClassesRoot, -2147483648 },
        new object[] { RegistryHive.CurrentUser, -2147483647 },
        new object[] { RegistryHive.LocalMachine, -2147483646 },
        new object[] { RegistryHive.Users, -2147483645 },
        new object[] { RegistryHive.PerformanceData, -2147483644 },
        new object[] { RegistryHive.CurrentConfig, -2147483643 },
    };

    [Theory]
    [MemberData(nameof(TestValues_EnumMemberToStringFast))]
    public void Test_EnumMemberToStringFast(RegistryHive member, string expectedStringValue)
    {
        var actualValue = member.ToStringFast();
        actualValue.Should().Be(expectedStringValue);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static IEnumerable<object[]> TestValues_EnumMemberToStringFast => new[]
    {
        new object[] { RegistryHive.ClassesRoot, "HKEY_CLASSES_ROOT" },
        new object[] { RegistryHive.CurrentUser, "HKEY_CURRENT_USER" },
        new object[] { RegistryHive.LocalMachine, "HKEY_LOCAL_MACHINE" },
        new object[] { RegistryHive.Users, "HKEY_USERS" },
        new object[] { RegistryHive.PerformanceData, "HKEY_PERFORMANCE_DATA" },
        new object[] { RegistryHive.CurrentConfig, "HKEY_CURRENT_CONFIG" },
    };

    [Fact]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryHive)} can be used on all platforms.")]
    public void Test_MirrorsOriginal()
    {
        var currentValues = RegistryHiveExtensions.GetValues();
        var originalValues = Enum.GetValues<MSRegistryHive>();

        currentValues.Should().Equal(originalValues, (currentValue, originalValue) =>
        {
            var current = (int)currentValue;
            var original = (int)originalValue;
            return current == original;
        });
    }
}
