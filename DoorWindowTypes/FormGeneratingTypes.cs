using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace DoorWindowTypes
{
    public partial class FormGeneratingTypes : Form
    {
        Document _doc;
        Element _elem;
        public FormGeneratingTypes(Document doc, Element elem)
        {
            InitializeComponent();
            _doc = doc;
            _elem = elem;

            ListBoxDWTypes.DisplayMember = "Name";
        }

        private void FormGeneratingTypes_Load(object sender, EventArgs e)
        {
            List<ElementId> elemTypesIds = _elem.GetValidTypes().ToList();

            List<FamilySymbol> elemTypes = new List<FamilySymbol>();

            foreach (ElementId typeId in elemTypesIds)
            {
                elemTypes.Add(_doc.GetElement(typeId) as FamilySymbol);
            }

            ListBoxDWTypes.BeginUpdate();

            foreach(FamilySymbol elem in elemTypes)
            {
                ListBoxDWTypes.Items.Add(elem);
            }

            ListBoxDWTypes.EndUpdate();
        }

        

        public Element CheckedType ()
        {
            Element elem = ListBoxDWTypes.SelectedItem as Element;
            
            return elem;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBoxPorog.Checked;

            ListBoxDWTypes.BeginUpdate();

            //List<FamilySymbol> elemTypes = ListBoxDWTypes.Items as List<FamilySymbol>;
            foreach(Element elem in ListBoxDWTypes.Items)
            {
                bool param = System.Convert.ToBoolean(elem.LookupParameter("Порог").AsInteger());
                if (param != check)
                {
                    ListBoxDWTypes.
                }
            }
        }
    }
}
