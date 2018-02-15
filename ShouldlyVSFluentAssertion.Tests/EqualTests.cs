using FluentAssertions;
using Shouldly;
using Xunit;

namespace ShouldlyVSFluentAssertion.Tests {
    public class EqualTests {
        [Fact]
        public void var1__are_equal_to__var2() {
            //arrange
            int var1;
            int var2;

            //act
            var1 = 10;
            var2 = 10;

            //assert
            //Shouldly
            var1.ShouldBe(var2);

            //Fluent Assertions
            var1.Should().Be(var2);
        }

        [Fact]
        public void var1__are_not_equal_to__var2() {
            //arrange
            short var1 = 10;
            short var2 = 110;

            //act
            var1 = 10;
            var2 = 110;

            //assert
            //Shouldly
            var1.ShouldNotBe(var2);

            //Fluent Assertions
            var1.Should().NotBe(var2);
        }
    }
}