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

        [Theory]
        [InlineData("", 0)]
        [InlineData("123", 3)]
        [InlineData("1234567890", 10)]
        public void length_of_string_val1_are_equals_to_val2(string val1, int val2) {
            //assert
            //Shouldly
            val1.Length.ShouldBe(val2);

            //Fluent Assertions
            val1.Should().HaveLength(val2);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("\u2000")]
        [InlineData("")]
        [InlineData("\t")]
        [InlineData(" ")]
        [InlineData("\t \n ")]
        [InlineData("\n")]
        public void string_val1_be_null_or_white_space(string val1) {
            //assert
            //Shouldly
            val1.ShouldBeNullOrWhiteSpace();

            //Fluent Assertions
            val1.Should().BeNullOrWhiteSpace();
        }

        [Theory]
        [InlineData("123")]
        [InlineData("not")]
        public void string_val_not_be_null_or_white_space(string val1) {
            //assert
            //Shouldly
            val1.ShouldNotBeNullOrWhiteSpace();

            //Fluent Assertions
            val1.Should().NotBeNullOrWhiteSpace();
        }
    }
}