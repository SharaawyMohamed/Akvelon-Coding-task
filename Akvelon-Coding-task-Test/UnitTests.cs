using Akvelon_Coding_task;
using FluentAssertions;

namespace Akvelon_Coding_task_Test
{
	public class UnitTests
	{
		private readonly FizzBuzzDetector _detector = new FizzBuzzDetector();

		[Fact]
		public void GetOverLappings_TestMainTest_ShoulGetSuccessResult()
		{
			// Arrange
			var input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
			// Act
			var result = _detector.getOverlappings(input);
			// Assert
			result.Result.Should().Be("Mary had Fizz little Buzz Fizz lamb, little Fizz Buzz had Fizz little lamb FizzBuzz fleece was Fizz as Buzz");
			result.Count.Should().Be(9);
		}
		[Fact]
		public void GetOverlappings_ShouldReplaceThirdWordWithFizzAndFifthWordWithBuzz()
		{
			// Arrange
			var input = "one two three four five";

			// Act
			var result = _detector.getOverlappings(input);

			// Assert
			result.Result.Should().Be("one two Fizz four Buzz");
			result.Count.Should().Be(2);
		}

		[Fact]
		public void GetOverlappings_ShouldReplaceThirdWorWithFizzAndFifthWordWithBuzzAndSixWordWithFizz()
		{
			// Arrange
			var input = "one two three four five six";

			// Act
			var result = _detector.getOverlappings(input);

			// Assert
			result.Result.Should().Be("one two Fizz four Buzz Fizz");
			result.Count.Should().Be(3);
		}

		[Fact]
		public void GetOverlappings_ShouldReplaceFifteenthWordWithFizzBuzz()
		{
			// Arrange
			var input = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15";

			// Act
			var result = _detector.getOverlappings(input);

			// Assert
			result.Result.Should().Be("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz");
			result.Count.Should().Be(7);
		}

		[Fact]
		public void GetOverlappings_WhenInputLenthLessThan7_ShouldGetFialruResponse()
		{
			// Arrange
			var input = "line1 ";

			// Act
			var result = _detector.getOverlappings(input);

			// Assert
			result.Result.Should().Be("Invalid Input, input length should be more than 6 characters");
			result.Count.Should().Be(0);
		}

		[Fact]
		public void GetOverlappings_whenInputLengthMoreThan100CharachterShouldGetInvalidResponse()
		{
			// Arrange
			var input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";

			// Act
			var result = _detector.getOverlappings(input);

			// Assert
			result.Result.Should().Be("Invalid Input, input length should be less than 101 characters");
			result.Count.Should().Be(0);
		}

	}
}