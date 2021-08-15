using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace ControlsDemo
{
    public class ControlsDemoUtil
    {
        [CommandMethod("Demo")]
        public void Demo()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
