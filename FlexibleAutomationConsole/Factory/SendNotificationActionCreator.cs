using System;
using FlexibleAutomationTool.FactoryDemo.Actions;

namespace FlexibleAutomationTool.FactoryDemo.Factory
{
    public class SendNotificationActionCreator : IActionCreator
    {
        public IAutomationAction CreateAction(string parameters)
        {
            // "channel=...;message=..."
            var parts = parameters.Split(';', StringSplitOptions.RemoveEmptyEntries);

            string channel = parts[0].Replace("channel=", string.Empty);
            string message = parts[1].Replace("message=", string.Empty);

            return new SendNotificationAction(channel, message);
        }
    }
}
