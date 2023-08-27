using Shouldly;

namespace Kata.FizzBuzz.Test._2._BonusMission
{
    public class FizzBuzzSagaShould
    {
        /*
         * Test your spells using TDD approach.
         */

        [Fact]
        public async Task TestFoo_Withxx_Expectxx()
        {
            // Arrange
            var testee = new Code._2._BonusMission.FizzBuzz();

            // Act
            var result = await testee.DoIt();

            // Assert
            result.ShouldNotBeNull();
        }
    }
}