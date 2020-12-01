using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB;

namespace DoorWindowTypes
{
    public class SelectionFilterDoorWindow : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            if(elem.Category.Id.IntegerValue == -2000023 | elem.Category.Id.IntegerValue == -2000014)
            {
                return true;
            }
            return false;
        }

        public bool AllowReference(Reference refer, XYZ point)
        {
            return true;
        }
    }
}
