using System.Diagnostics.CodeAnalysis;
using RegistryUtils.Core.Types;
using MSRegistryView = Microsoft.Win32.RegistryView;

namespace RegistryUtils.Core.Tests.Types;

public class RegistryViewTests
{
    [Theory]
    [MemberData(nameof(TestValues_EnumMemberToValue))]
    public void Test_EnumMemberToValue(RegistryView member, int expectedValue)
    {
        var actualValue = (int)member;
        actualValue.Should().Be(expectedValue);
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static IEnumerable<object[]> TestValues_EnumMemberToValue => new[]
    {
        new object[] { RegistryView.Default, 0 },
        new object[] { RegistryView.Registry64, 256 },
        new object[] { RegistryView.Registry32, 512 },
    };

    [Fact]
    [UnconditionalSuppressMessage(
        "",
        "CA1416",
        Justification = $"{nameof(MSRegistryView)} can be used on all platforms.")]
    public void Test_MirrorsOriginal()
    {
        var currentValues = RegistryViewExtensions.GetValues().OrderBy(x => (int)x);
        var originalValues = Enum.GetValues<MSRegistryView>().OrderBy(x => (int)x);

        currentValues.Should().Equal(originalValues, (currentValue, originalValue) =>
        {
            var current = (int)currentValue;
            var original = (int)originalValue;
            return current == original;
        });
    }
}
