using System;

namespace FlexibleAutomationTool.FactoryDemo.Actions
{
    public class SetStatusAction : IAutomationAction
    {
        public string Name => "SetStatus";

        private readonly string _service;
        private readonly string _status;

        public SetStatusAction(string service, string status)
        {
            _service = service;
            _status = status;
        }

        public void Execute()
        {
            Console.WriteLine($"[ACTION] Setting status '{_status}' for '{_service}'...");
        }
    }
}
