using Xunit;

namespace API.Tests
{
	public class MessageGeneratorFacts
	{
		[Fact]
		public void GeneratesAMessage()
		{
			var generator = new MessageGenerator();
			var message = generator.GenerateMessage("Test");
			Assert.Equal("Test", message);
		}
	}
}