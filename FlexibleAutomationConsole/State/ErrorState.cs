using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class ErrorState : IRuleState
    {
        public string Name => "Error";

        private readonly string _errorMessage;

        public ErrorState(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public void Handle(AutomationRule rule)
        {
            rule.Log($"Rule is in error state: {_errorMessage}");
        }
    }
}
