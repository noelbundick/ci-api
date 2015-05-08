using System.Collections.Generic;
using API.Controllers;
using API.Models;
using Xunit;

namespace API.Tests
{
	public class UsersControllerFacts
	{
		UsersController controller;
		
		public UsersControllerFacts()
		{
			var users = new List<User> {
				new User(1, "Steve Rogers"),
				new User(2, "Bruce Banner")
			};
			controller = new UsersController(users);
		}
		
		[Fact]
		public void ItExists()
		{
			var controller = new UsersController();
			Assert.NotNull(controller);
		}
		
		[Fact]
		public void GetReturnsAListOfUsers()
		{
			var controller = new UsersController();
			var users = controller.Get();
			Assert.NotEmpty(users);
			Assert.All(users, u => Assert.IsType(typeof(User), u));
		}
	}
}