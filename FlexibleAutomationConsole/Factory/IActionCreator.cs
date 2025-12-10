using FlexibleAutomationTool.FactoryDemo.Actions;

namespace FlexibleAutomationTool.FactoryDemo.Factory
{
    public interface IActionCreator
    {
        IAutomationAction CreateAction(string parameters);
    }
}
