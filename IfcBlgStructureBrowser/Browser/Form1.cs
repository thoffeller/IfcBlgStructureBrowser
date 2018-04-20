using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        static string m_filename = "";
        static Ifc4.Document m_ifcDocument = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void _buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "ifcXml files (*.ifcxml)|*.ifcxml";
            dlg.CheckFileExists = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                m_filename = dlg.FileName;
            }

            LoadXML();
        }

        /// <summary>
        /// Loading the ifc xml from file
        /// </summary>
        private void LoadXML()
        {
            if (File.Exists(m_filename))
            {
                m_ifcDocument = Ifc4.Workspace.CurrentWorkspace.OpenDocument(m_filename);
                if(m_ifcDocument != null)
                {
                    try
                    {
                        _richTextBox.Text += m_ifcDocument.Project.Name + "\n";
                        if (m_ifcDocument.Project.Sites != null)
                        {
                            Ifc4.IfcSite site = m_ifcDocument.Project.Sites.First();

                            _richTextBox.Text += site.LongName + "\n";
                            foreach (Ifc4.IfcBuilding bldg in site.Buildings)
                            {
                                _richTextBox.Text += bldg.LongName + "\n";

                                foreach (Ifc4.IfcBuildingStorey storey in bldg.BuildingStoreys)
                                {
                                    _richTextBox.Text += storey.LongName + "\n";

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifcFullName = @"C:\tmp\a.ifcxml";
            Ifc4.Document document = Ifc4.Workspace.CurrentWorkspace.CreateDocument(ifcFullName, true);

            var header = document.IfcXmlDocument.Header;
            header.Organization = "My Organisation";

            var ifcSite = document.Project.Sites.AddNewSite();
            ifcSite.LongName = "A-Project";

            var ifcBuilding = ifcSite.Buildings.AddNewBuilding();
            ifcBuilding.LongName = "B-Building";

            var ifcBuildingStorey = ifcBuilding.BuildingStoreys.AddNewBuildingStorey();
            ifcBuildingStorey.LongName = "C-Storey";

            var ifcSpace = ifcBuildingStorey.Spaces.AddNewSpace();
            ifcSpace.LongName = "D-Room";

            document.Workspace.SaveDocument(ifcFullName);
        }
    }
}
