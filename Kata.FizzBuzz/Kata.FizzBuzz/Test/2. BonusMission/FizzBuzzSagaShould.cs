using Shouldly;
using Xunit.Abstractions;

namespace Kata.FizzBuzz.Test._2._BonusMission
{
    public class FizzBuzzSagaShould
    {
		/*
         * Test your spells using TDD approach.
         */
		
        private readonly ITestOutputHelper _outputHelper;

        public FizzBuzzSagaShould(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async Task TestFoo_Withxx_Expectxx()
        {
            // Arrange
            var testee = new Code._2._BonusMission.FizzBuzz();

            // Act
            //var result = await testee.DoIt();

            // Assert
            //result.ShouldNotBeNull();
        }
    }
}