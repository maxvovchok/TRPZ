using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class DraftState : IRuleState
    {
        public string Name => "Draft";

        public void Handle(AutomationRule rule)
        {
            rule.Log("Rule is in draft state. Execution is not allowed.");
            rule.TransitionTo(new ActiveState());
        }
    }
}
