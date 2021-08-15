using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            string choice = "";

            choice = CbbOptions.SelectedItem.ToString();
            ControlsDemoUtil controlsDemoUtil = new ControlsDemoUtil();

            if (choice == "Layer")
            {
                ArrayList layerList = controlsDemoUtil.GetLayers();
                LstLayer.DataSource = layerList;
                LstLinetype.DataSource = null;
                LstTextstyle.DataSource = null;
                LblLayerCount.Text = "Layers count: " + layerList.Count;
            }
            else if (choice == "Linetype")
            {
                ArrayList linetypeList = controlsDemoUtil.GetLinetypes();
                LstLayer.DataSource = null;
                LstLinetype.DataSource = linetypeList;
                LstTextstyle.DataSource = null;
                LblLinetypeCount.Text = "Linetype count: " + linetypeList.Count;
            }
            else if (choice == "Textstyle")
            {
                ArrayList textstyleList = controlsDemoUtil.GetTextstyles();
                LstLayer.DataSource = null;
                LstLinetype.DataSource = null;
                LstTextstyle.DataSource = textstyleList;
                LblTextstyleCount.Text = "Textstyle count: " + textstyleList.Count;
            }
            else if (choice == "All")
            {
                ArrayList layerList = controlsDemoUtil.GetLayers();
                ArrayList linetypeList = controlsDemoUtil.GetLinetypes();
                ArrayList textstyleList = controlsDemoUtil.GetTextstyles();
                LstLayer.DataSource = layerList;
                LstLinetype.DataSource = linetypeList;
                LstTextstyle.DataSource = textstyleList;
                LblLayerCount.Text = "Layers count: " + layerList.Count;
                LblLinetypeCount.Text = "Linetype count: " + linetypeList.Count;
                LblTextstyleCount.Text = "Textstyle count: " + textstyleList.Count;
            }
        }
    }
}
