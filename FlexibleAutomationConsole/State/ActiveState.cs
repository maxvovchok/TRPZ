using System;
using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public class ActiveState : IRuleState
    {
        public string Name => "Active";

        public void Handle(AutomationRule rule)
        {
            try
            {
                rule.Log("Rule is active. Starting execution...");
                rule.ExecuteActions();
                rule.TransitionTo(new CompletedState());
            }
            catch (Exception ex)
            {
                rule.Log($"Execution failed: {ex.Message}");
                rule.TransitionTo(new ErrorState(ex.Message));
            }
        }
    }
}
