using Shouldly;
using Xunit.Abstractions;

namespace Kata.FizzBuzz.Test._1._MainMission
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
            var testee = new Code._1._MainMission.FizzBuzz();

            // Act
            //var result = await testee.DoIt();

            // Assert
            //result.ShouldNotBeNull();
        }
    }
}