using FlexibleAutomationTool.Domain;

namespace FlexibleAutomationTool.State
{
    public interface IRuleState
    {
        void Handle(AutomationRule rule);
        string Name { get; }
    }
}
