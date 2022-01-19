using Xunit;
namespace Calculations.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Francisco", "Mejias");
            Assert.Equal("francisco Mejias", result, ignoreCase:true);
            Assert.Contains("Cisco", result, System.StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            var result = names.NickName;
            Assert.Null(result);

            names.NickName = "Pancho";
            Assert.NotNull(names);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Francisco", "Mejias");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
