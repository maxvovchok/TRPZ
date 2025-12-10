using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class PausedState : IRuleState
    {
        public string Name => "Paused";

        public void Handle(AutomationRule rule)
        {
            rule.Log("Rule is paused. Execution is skipped.");
        }
    }
}
