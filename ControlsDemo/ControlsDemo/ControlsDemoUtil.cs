using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System.Collections;

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

        public ArrayList GetLayers()
        {
            ArrayList layers = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                LayerTable lyTab = transaction.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;

                foreach (var ly in lyTab)
                {
                    LayerTableRecord lytr = transaction.GetObject(ly, OpenMode.ForRead) as LayerTableRecord;
                    layers.Add(lytr.Name);
                }
            }

            return layers;
        }

        public ArrayList GetLinetypes()
        {
            ArrayList linetypes = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                LinetypeTable ltTab = transaction.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;

                foreach (var lt in ltTab)
                {
                    LinetypeTableRecord lttr = transaction.GetObject(lt, OpenMode.ForRead) as LinetypeTableRecord;
                    linetypes.Add(lttr.Name);
                }
            }

            return linetypes;
        }

        public ArrayList GetTextstyles()
        {
            ArrayList textstyles = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                TextStyleTable tsTab = transaction.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;

                foreach (var ts in tsTab)
                {
                    TextStyleTableRecord tstr = transaction.GetObject(ts, OpenMode.ForRead) as TextStyleTableRecord;
                    textstyles.Add(tstr.Name);
                }
            }

            return textstyles;
        }
    }
}
