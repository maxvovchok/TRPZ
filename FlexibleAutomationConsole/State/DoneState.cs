using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class DoneState : IRuleState
    {
        public string Name => "Done";

        public void Handle(AutomationRule rule)
        {
            rule.Log("Rule is in final state. No further processing.");
        }
    }
}
