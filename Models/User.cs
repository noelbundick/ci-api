using System;

namespace API.Models
{
	public class User
	{
		public User(int id, string name)
		{
			Id = id;
			Name = name;
		}
		
		public int Id { get; private set; }
		public string Name { get; set; }
	}
}