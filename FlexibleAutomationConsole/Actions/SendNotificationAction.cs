using System;

namespace FlexibleAutomationTool.FactoryDemo.Actions
{
    public class SendNotificationAction : IAutomationAction
    {
        public string Name => "SendNotification";

        private readonly string _channel;
        private readonly string _message;

        public SendNotificationAction(string channel, string message)
        {
            _channel = channel;
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"[ACTION] Sending notification via '{_channel}': {_message}");
        }
    }
}
