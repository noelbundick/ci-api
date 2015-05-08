using Xunit;

namespace API.Tests 
{
	public class SampleFacts
	{
		[Fact]
		public void TwoPlusTwoReturnsFour() 
		{
			var result = 2 + 2;
			Assert.Equal(4, result);
		}
	}
}