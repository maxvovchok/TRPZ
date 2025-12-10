namespace FlexibleAutomationTool.FactoryDemo.Actions
{
    public interface IAutomationAction
    {
        string Name { get; }
        void Execute();
    }
}
