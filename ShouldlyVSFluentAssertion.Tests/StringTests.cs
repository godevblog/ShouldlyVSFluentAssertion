using FluentAssertions;
using Shouldly;
using Xunit;

namespace ShouldlyVSFluentAssertion.Tests {
    public class StringTests {
        [Fact]
        public void string_val1_are_empty() {
            //arrange
            string val1;

            //act
            val1 = "";

            //assert
            //Shouldly
            val1.ShouldBeEmpty();

            //Fluent Assertions
            val1.Should().BeEmpty();
        }
    }
}