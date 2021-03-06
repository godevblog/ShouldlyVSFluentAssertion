using FluentAssertions;
using Shouldly;
using Xunit;

namespace ShouldlyVSFluentAssertion.Tests {
    public class BooleanTests {
        [Fact]
        public void result_true_when_bool1_are_true() {
            //arrange
            bool bool1;

            //act
            bool1 = true;

            //assert
            //Shouldly
            bool1.ShouldBeTrue();
            bool1.ShouldBe(true);

            //Fluent Assertions
            bool1.Should().BeTrue();
            bool1.Should().Be(true);
        }

        [Fact]
        public void result_false_when_bool1_are_false() {
            //arrange
            bool bool1;

            //act
            bool1 = false;

            //assert
            //Shouldly
            bool1.ShouldBeFalse();
            bool1.ShouldBe(false);

            //Fluent Assertions
            bool1.Should().BeFalse();
            bool1.Should().Be(false);
        }
    }
}