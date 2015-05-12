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
		
		[Fact]
		public void PassingTest()
		{
			Assert.True(true);
		}
		
		[Fact]
		public void AnotherPassingTest()
		{
			var x = 3;
			var y = 5;
			var z = x + y;
			Assert.Equal(8, z);
		}
		
		[Fact]
		public void TDDNewFeature()
		{
			Assert.True(true);
		}
	}
}