using System;

namespace FlexibleAutomationTool.FactoryDemo.Factory
{
    public static class ActionFactory
    {
        public static IActionCreator ResolveCreator(AutomationActionType type)
        {
            return type switch
            {
                AutomationActionType.DownloadFile    => new DownloadFileActionCreator(),
                AutomationActionType.SetStatus       => new SetStatusActionCreator(),
                AutomationActionType.SendNotification => new SendNotificationActionCreator(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}
