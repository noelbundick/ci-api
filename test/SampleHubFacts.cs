using API.Hubs;
using Xunit;

namespace API.Tests 
{
	public class SampleHubFacts
	{
		[Fact]
		public void ItExists() 
		{
			var hub = new SampleHub();
			Assert.NotNull(hub);
		}
	}
}