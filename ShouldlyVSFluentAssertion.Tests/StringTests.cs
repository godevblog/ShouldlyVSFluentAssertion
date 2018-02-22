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

        [Fact]
        public void string_val_1_are_equivalent_to_string_val_2() {
            //arrange
            string val1;
            string val2;

            //act
            val1 = "text";
            val2 = "TEXT";

            //assert
            //Fluent Assertions
            val1.Should().BeEquivalentTo(val2);
        }

        [Fact]
        public void string_val_1_start_with_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "Test";
            val2 = "T";

            //assert
            //Shouldly
            val1.ShouldStartWith(val2);

            //Fluent Assertions
            val1.Should().StartWith(val2);
        }

        [Fact]
        public void string_val_1_not_start_with_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "Test";
            val2 = "S";

            //assert
            //Shouldly
            val1.ShouldNotStartWith(val2);

            //Fluent Assertions
            val1.Should().NotStartWith(val2);
        }

          [Fact]
        public void string_val_1_end_with_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "1234567890";
            val2 = "0";

            //assert
            //Shouldly
            val1.ShouldEndWith(val2);

            //Fluent Assertions
            val1.Should().EndWith(val2);
        }

        [Fact]
        public void string_val_1_not_end_with_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "1234567890";
            val2 = "1";

            //assert
            //Shouldly
            val1.ShouldNotEndWith(val2);

            //Fluent Assertions
            val1.Should().NotEndWith(val2);
        }

        [Fact]
        public void string_val1_should_contain_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "text to contain";
            val2 = "to";

            //assert
            //Shouldly
            val1.ShouldContain(val2);

            //Fluent Assertion
            val1.Should().Contain(val2);
        }

        [Fact]
        public void string_val1_should_not_contain_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "text to contain";
            val2 = "XXX";

            //assert
            //Shouldly
            val1.ShouldNotContain(val2);

            //Fluent Assertion
            val1.Should().NotContain(val2);
        }

        [Fact]
        public void string_val_1_should_match_on_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "Teeeeeeeeest";
            val2 = @"T.e{8}s[t]";

            //assert
            //Shouldly
            val1.ShouldMatch(val2);

            //Fluent Assertions
            val1.Should().MatchRegex(val2);
        }

         [Fact]
        public void string_val_1_should_not_match_on_string_val_2(){
            //arrange
            string val1;
            string val2;

            //act
            val1 = "Teeeeeeeeest";
            val2 = @"abab[a]";

            //assert
            //Shouldly
            val1.ShouldNotMatch(val2);

            //Fluent Assertions
            val1.Should().NotMatchRegex(val2);
        }
    }
}