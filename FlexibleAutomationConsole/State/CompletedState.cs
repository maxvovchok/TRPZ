using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class CompletedState : IRuleState
    {
        public string Name => "Completed";

        public void Handle(AutomationRule rule)
        {
            rule.Log("Rule is already completed. No execution needed.");
            rule.TransitionTo(new DoneState());
        }
    }
}
