
|Fluent Assertions|Porównanie|Shouldly|
|-:|:-:|:-|
|Install-Package FluentAssertions|Instalacja w VS|Install-Package Shouldly|
|dotnet add package FluentAssertions|Instalacja w VS Code|dotnet add package Shouldly|

|Fluent Assertions| Asercja |Shouldly|
|-:|:-:|:-|
|val1.Should().Be(val2)| val1 = val2 |val1.ShouldBe(val2)|
|val1.Should().NotBe(val2)| val1 != val2 |val1.ShouldNotBe(val2)|
|
|val1.Should().BeTrue()| val1 = True |val1.ShouldBeTrue()|
|val1.Should().BeFalse()| val1 = False |val1.ShouldBeTrue()|
|
|val1.Should().NotHaveValue()|val1 = null|val1.ShouldBeNull()|
|val1.Should().HaveValue()|val1 != null|val1.ShouldNotBeNull()|
|
|val1.Should().BeEmpty()|val1 = ""|val1.ShouldBeEmpty()|
|val1.Should().HaveLength(val2)|val1.Length = val2|val1.Length.ShouldBe(val2);|
|val1.Should().BeNullOrWhiteSpace()|val1 != null|val1.ShouldBeNullOrWhiteSpace()|
|val1.Should().NotBeNullOrWhiteSpace()|val1 != null|val1.ShouldNotBeNullOrWhiteSpace()|

|val1.Should().BeEquivalentTo(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().Contain(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotContain(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().ContainEquivalentOf(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotContainEquivalentOf(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().StartWith(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotStartWith(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().StartWithEquivalent(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotStartWithEquivalent(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().EndWith(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotEndWith(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().EndWithEquivalent(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotEndWithEquivalent(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().Match(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().MatchEquivalentOf(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().MatchRegex(val2)|val1 != null|val1.ShouldNotBeNull()|
|val1.Should().NotMatchRegex(val2)|val1 != null|val1.ShouldNotBeNull()|
