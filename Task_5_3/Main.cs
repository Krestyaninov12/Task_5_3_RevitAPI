using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Task_5_3
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Task 5_3";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\Program Files\RevitAPITrainig\"; 

            var panel = application.CreateRibbonPanel(tabName, "панель 5 3");

            var button1 = new PushButtonData("5_1", "1",
                Path.Combine(utilsFolderPath, "Task_5_1.dll"),
                "Task_5_1.Main");

            Uri uriImage1 = new Uri(@"C:\Program Files\Task_5_3\Task_5_3\Task_5_3\Images\RevitAPITrainingUI_32.png", UriKind.Absolute);
            BitmapImage largeImage1 = new BitmapImage(uriImage1);
            button1.LargeImage = largeImage1;

            panel.AddItem(button1);

            var button2 = new PushButtonData("5_2", "2",
                Path.Combine(utilsFolderPath, "Task_5_2.dll"),
                "Task_5_2.Main");

            Uri uriImage2 = new Uri(@"C:\Program Files\Task_5_3\Task_5_3\Task_5_3\Images\RevitAPITrainingUI_32.png", UriKind.Absolute); 
            BitmapImage largeImage2 = new BitmapImage(uriImage2);
            button2.LargeImage = largeImage2;

            panel.AddItem(button2);

            return Result.Succeeded;
        }


    }
}
