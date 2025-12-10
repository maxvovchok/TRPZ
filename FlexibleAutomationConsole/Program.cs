using System;
using System.Collections.Generic;
using FlexibleAutomationTool.FactoryDemo.Actions;
using FlexibleAutomationTool.FactoryDemo.Factory;

namespace FlexibleAutomationTool.FactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configs = new List<(AutomationActionType Type, string Parameters)>
            {
                (AutomationActionType.DownloadFile,
                    "url=https://example.com/file.zip;dest=/tmp/file.zip"),
                (AutomationActionType.SetStatus,
                    "service=Skype;status=Away"),
                (AutomationActionType.SendNotification,
                    "channel=email;message=Automation completed")
            };

            var actions = new List<IAutomationAction>();

            foreach (var cfg in configs)
            {
                var creator = ActionFactory.ResolveCreator(cfg.Type);
                IAutomationAction action = creator.CreateAction(cfg.Parameters);
                actions.Add(action);
            }

            Console.WriteLine("=== FACTORY METHOD DEMO ===");
            foreach (var action in actions)
            {
                Console.WriteLine($"Executing action: {action.Name}");
                action.Execute();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
