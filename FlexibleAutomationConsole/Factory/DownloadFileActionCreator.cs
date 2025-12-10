using System;
using FlexibleAutomationTool.FactoryDemo.Actions;

namespace FlexibleAutomationTool.FactoryDemo.Factory
{
    public class DownloadFileActionCreator : IActionCreator
    {
        public IAutomationAction CreateAction(string parameters)
        {
            // Очікуємо формат: "url=...;dest=..."
            var parts = parameters.Split(';', StringSplitOptions.RemoveEmptyEntries);

            string url = parts[0].Replace("url=", string.Empty);
            string dest = parts[1].Replace("dest=", string.Empty);

            return new DownloadFileAction(url, dest);
        }
    }
}
