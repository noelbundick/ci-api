using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace API.Hubs
{
	public class SampleHub : Hub
	{
		private readonly MessageGenerator _messageGenerator;
		
		public SampleHub(MessageGenerator generator)
		{
			_messageGenerator = generator;
		}
		
		public SampleHub() : this(new MessageGenerator()) {}
		
		public override Task OnConnected() 
		{
			Clients.Caller.addMessage("System", "You are now connected");
			var message = _messageGenerator.GenerateMessage(
				"A new client has connected with id: " + Context.ConnectionId);
			SendMessage("System", message);
			return base.OnConnected();
		}
		
		public void SendMessage(string name, string message)
		{
			Clients.All.addMessage(name, message);
		}
	}
}