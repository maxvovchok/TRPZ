using System;

namespace FlexibleAutomationTool.FactoryDemo.Actions
{
    public class DownloadFileAction : IAutomationAction
    {
        public string Name => "DownloadFile";

        private readonly string _url;
        private readonly string _destinationPath;

        public DownloadFileAction(string url, string destinationPath)
        {
            _url = url;
            _destinationPath = destinationPath;
        }

        public void Execute()
        {
            Console.WriteLine($"[ACTION] Downloading '{_url}' to '{_destinationPath}'...");
            // Тут могла б бути реальна логіка завантаження файлу
        }
    }
}
