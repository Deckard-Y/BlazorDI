namespace BlazorDI.Service
{

    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the service!";
        }
    }

}
