#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using RVTAppServ = Autodesk.Revit.ApplicationServices.Application;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace DoorWindowTypes
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            RVTAppServ app = uiapp.Application;
            Document doc = uidoc.Document;

            Selection sel = uidoc.Selection;

            SelectionFilterDoorWindow selFilter = new SelectionFilterDoorWindow();

            Reference refer = sel.PickObject(ObjectType.Element, selFilter, "Выберите дверь или окно");
            FamilyInstance faminst = doc.GetElement(refer.ElementId) as FamilyInstance;

            FormGeneratingTypes form = new FormGeneratingTypes(doc, faminst);
            form.ShowDialog();

            Element elem = form.CheckedType();

            if (elem == null)
                return Result.Cancelled;

            TaskDialog.Show("TypeName", elem.Name);

            //TaskDialog.Show("ElementId", faminst.Id.ToString());

            return Result.Succeeded;
        }
    }
}
