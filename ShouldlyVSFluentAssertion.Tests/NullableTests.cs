using FluentAssertions;
using Shouldly;
using Xunit;

namespace ShouldlyVSFluentAssertion.Tests {

    public class NullableTests {
        [Fact]
        public void val1_are_null(){
            //arragne
            short? val1;

            //act
            val1 = null;

            //assert
            //Shouldly
            val1.ShouldBeNull();

            //FluentAssertions
            val1.Should().NotHaveValue();
        }

        [Fact]
        public void val1_are_not_null(){
            //arragne
            int? val1;

            //act
            val1 = 0;

            //assert
            //Shouldly
            val1.ShouldNotBeNull();

            //Fluent Assertions
            val1.Should().HaveValue();
        }
    }
}