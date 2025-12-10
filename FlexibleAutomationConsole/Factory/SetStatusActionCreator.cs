using System;
using FlexibleAutomationTool.FactoryDemo.Actions;

namespace FlexibleAutomationTool.FactoryDemo.Factory
{
    public class SetStatusActionCreator : IActionCreator
    {
        public IAutomationAction CreateAction(string parameters)
        {
            // "service=...;status=..."
            var parts = parameters.Split(';', StringSplitOptions.RemoveEmptyEntries);

            string service = parts[0].Replace("service=", string.Empty);
            string status = parts[1].Replace("status=", string.Empty);

            return new SetStatusAction(service, status);
        }
    }
}
