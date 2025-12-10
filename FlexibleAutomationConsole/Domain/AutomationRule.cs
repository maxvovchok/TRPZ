using System;
using FlexibleAutomationTool.State;

namespace FlexibleAutomationTool.Domain
{
    public class AutomationRule
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ScheduleExpression { get; set; } = string.Empty;

        private IRuleState _state;

        public AutomationRule(IRuleState initialState)
        {
            TransitionTo(initialState);
        }

        public void TransitionTo(IRuleState newState)
        {
            Console.WriteLine($"Rule [{Name}] transition to state: {newState.Name}");
            _state = newState;
        }

        public void Handle()
        {
            _state.Handle(this);
        }

        public void ExecuteActions()
        {
            Console.WriteLine($"Rule [{Name}] is executing actions...");
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG][{Name}] {message}");
        }
    }
}
