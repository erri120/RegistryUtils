using System.Diagnostics.CodeAnalysis;
using RegistryUtils.Core.Types;
using MSRegistryValueKind = Microsoft.Win32.RegistryValueKind;

namespace RegistryUtils.Core.Tests.Types;

public class RegistryValueKindTests
{
    [Theory]
    [MemberData(nameof(TestValues_EnumMemberToValue))]
    public void Test_EnumMemberToValue(RegistryValueKind member, int expectedValue)
    {
        var actualValue = (int)member;
        actualValue.Should().Be(expectedValue);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static IEnumerable<object[]> TestValues_EnumMemberToValue => new[]
    {
        new object[] { RegistryValueKind.None, -1 },
        new object[] { RegistryValueKind.Unknown, 0 },
        new object[] { RegistryValueKind.String, 1 },
        new object[] { RegistryValueKind.ExpandString, 2 },
        new object[] { RegistryValueKind.Binary, 3 },
        new object[] { RegistryValueKind.DWord, 4 },
        new object[] { RegistryValueKind.MultiString, 7 },
        new object[] { RegistryValueKind.QWord, 11 },
    };

    [Theory]
    [MemberData(nameof(TestValues_EnumMemberToStringFast))]
    public void Test_EnumMemberToStringFast(RegistryValueKind member, string expectedStringValue)
    {
        var actualValue = member.ToStringFast();
        actualValue.Should().Be(expectedStringValue);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static IEnumerable<object[]> TestValues_EnumMemberToStringFast => new[]
    {
        new object[] { RegistryValueKind.None, "None" },
        new object[] { RegistryValueKind.Unknown, "Unknown" },
        new object[] { RegistryValueKind.String, "REG_SZ" },
        new object[] { RegistryValueKind.ExpandString, "REG_EXPAND_SZ" },
        new object[] { RegistryValueKind.Binary, "REG_BINARY" },
        new object[] { RegistryValueKind.DWord, "REG_DWORD" },
        new object[] { RegistryValueKind.MultiString, "REG_MULTI_SZ" },
        new object[] { RegistryValueKind.QWord, "REG_QWORD" },
    };

    [Fact]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryValueKind)} can be used on all platforms.")]
    public void Test_MirrorsOriginal()
    {
        var currentValues = RegistryValueKindExtensions.GetValues().OrderBy(x => (int)x);
        var originalValues = Enum.GetValues<MSRegistryValueKind>().OrderBy(x => (int)x);

        currentValues.Should().Equal(originalValues, (currentValue, originalValue) =>
        {
            var current = (int)currentValue;
            var original = (int)originalValue;
            return current == original;
        });
    }
}
