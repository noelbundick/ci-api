using API.Controllers;
using Xunit;

namespace API.Tests
{
	public class UsersControllerFacts
	{
		[Fact]
		public void ItExists()
		{
			var controller = new UsersController();
			Assert.NotNull(controller);
		}
	}
}